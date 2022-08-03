//
// SporeServer - https://github.com/Rosalie241/SporeServer
//  Copyright (C) 2021 Rosalie Wanders <rosalie@mailbox.org>
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Affero General Public License version 3.
//  You should have received a copy of the GNU Affero General Public License
//  along with this program. If not, see <https://www.gnu.org/licenses/>.
//
#ifndef SPORENEWOPENSSL_HPP
#define SPORENEWOPENSSL_HPP

namespace OpenSSL
{
    void Initialize(void);

    void AttachDetours(void);
}

#endif // SPORENEWOPENSSL_HPP
