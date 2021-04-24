﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SporeServer.Areas.Identity.Data;
using SporeServer.Data;
using SporeServer.Models;
using SporeServer.Models.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SporeServer.Controllers.Pollinator
{
    [Authorize]
    [Route("Pollinator/public-interface")]
    [ApiController]
    public class PublicInterfaceController : ControllerBase
    {
        private readonly SporeServerContext _context;
        private readonly UserManager<SporeServerUser> _userManager;
        private readonly IWebHostEnvironment _env;
        public PublicInterfaceController(SporeServerContext context, UserManager<SporeServerUser> userManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }

        // POST /pollinator/public-interface/AssetUploadServlet
        [HttpPost("AssetUploadServlet")]
        public async Task<IActionResult> AssetUploadServlet([FromForm] AssetUploadForm formAsset)
        {
            Console.WriteLine($"Pollinator/public-interface/AssetUploadServlet{Request.QueryString}");

            int slurpValue;

            // the game client always sends the slurp query
            // and it's always either 0 or 1
            if (!Request.Query.ContainsKey("slurp") ||
                !int.TryParse(Request.Query["slurp"], out slurpValue) ||
                (slurpValue != 0 && slurpValue != 1))
            {
                Console.WriteLine("no slurp valueeeee");
                return Ok();
            }

            var asset = await _context.Assets.FindAsync(formAsset.AssetId);

            // make sure the asset isn't already used,
            // if we can't find it, something's wrong
            if (asset == null || 
                asset.Used)
            {
                Console.WriteLine("HNG USED");
                return Ok();
            }

            string baseFilePath = Path.Combine(_env.WebRootPath, "usercontent", $"{asset.AssetId}");

            try
            {
                SporeModel model = SporeModel.SerializeFromXml(formAsset.ModelData.OpenReadStream());
                SporeModel.Validate(model);

                System.IO.File.WriteAllText(baseFilePath + ".xml", SporeModel.DeserializeToxml(model));

                using (Stream stream = System.IO.File.OpenWrite(baseFilePath + ".png"))
                {
                    await formAsset.ThumbnailData.CopyToAsync(stream);
                    await stream.FlushAsync();
                }
            }
            catch (Exception e)
            {
                // cleanup when failed
                foreach (string file in new string[] { baseFilePath + ".xml", baseFilePath + ".png"})
                {
                    if (System.IO.File.Exists(file))
                    {
                        System.IO.File.Delete(file);
                    }
                }

                Console.WriteLine(e);
                return Ok();
            }

            // update the previously unused asset
            asset.Used = true;
            asset.Name = formAsset.ModelData.FileName;
            asset.Description = formAsset.Description;
            asset.Size = formAsset.ModelData.Length;
            asset.Slurped = slurpValue == 1;
            _context.Assets.Update(asset);

            // save the database
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("SnapshotUploadServlet")]
        public async Task<IActionResult> SnapshotUploadServlet()
        {
            Console.WriteLine("Pollinator/public-interface/SnapshotUploadServlet");

            var file = System.IO.File.OpenWrite("postcard.txt");

            await Request.Body.CopyToAsync(file);

            file.Flush();
            file.Close();

            return Ok();
        }
    }
}
