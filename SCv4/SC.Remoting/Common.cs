﻿/* 
ServerChecker v4 operates and manages various kinds of software on server systems.
Copyright (C) 2010 Stijn Devriendt

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC.Remoting
{
    internal enum EncryptionType
    {
        Unknown = 0,
        HandshakeRequest = 1,
        HandshakeResponse = 2,
        Encrypted = 4
    }
    internal enum AuthenticationType
    {
        Unknown = 0,
        ChallengeRequest = 1,
        ChallengeResponse = 2,
        Authenticated = 4
    }
    internal class CommonHeaders
    {
        public static string PublicKey = "PublicKey";
        public static string EncryptionType = "EncryptionType";
        public static string AuthenticationType = "AuthenticationType";
        public static string Username = "Username";
        public static string Challenge = "Challenge";
    }
}
