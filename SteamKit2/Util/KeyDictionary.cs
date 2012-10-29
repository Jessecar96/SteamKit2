﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */



using System.Collections.Generic;

namespace SteamKit2
{
    public static class KeyDictionary
    {
        static Dictionary<EUniverse, byte[]> keys = new Dictionary<EUniverse, byte[]>()
        {
            { EUniverse.Invalid, null },

            { EUniverse.Public, new byte[]
                {
                    0x30, 0x81, 0x9D, 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01,
                    0x05, 0x00, 0x03, 0x81, 0x8B, 0x00, 0x30, 0x81, 0x87, 0x02, 0x81, 0x81, 0x00, 0xDF, 0xEC, 0x1A,
                    0xD6, 0x2C, 0x10, 0x66, 0x2C, 0x17, 0x35, 0x3A, 0x14, 0xB0, 0x7C, 0x59, 0x11, 0x7F, 0x9D, 0xD3,
                    0xD8, 0x2B, 0x7A, 0xE3, 0xE0, 0x15, 0xCD, 0x19, 0x1E, 0x46, 0xE8, 0x7B, 0x87, 0x74, 0xA2, 0x18,
                    0x46, 0x31, 0xA9, 0x03, 0x14, 0x79, 0x82, 0x8E, 0xE9, 0x45, 0xA2, 0x49, 0x12, 0xA9, 0x23, 0x68,
                    0x73, 0x89, 0xCF, 0x69, 0xA1, 0xB1, 0x61, 0x46, 0xBD, 0xC1, 0xBE, 0xBF, 0xD6, 0x01, 0x1B, 0xD8,
                    0x81, 0xD4, 0xDC, 0x90, 0xFB, 0xFE, 0x4F, 0x52, 0x73, 0x66, 0xCB, 0x95, 0x70, 0xD7, 0xC5, 0x8E,
                    0xBA, 0x1C, 0x7A, 0x33, 0x75, 0xA1, 0x62, 0x34, 0x46, 0xBB, 0x60, 0xB7, 0x80, 0x68, 0xFA, 0x13,
                    0xA7, 0x7A, 0x8A, 0x37, 0x4B, 0x9E, 0xC6, 0xF4, 0x5D, 0x5F, 0x3A, 0x99, 0xF9, 0x9E, 0xC4, 0x3A,
                    0xE9, 0x63, 0xA2, 0xBB, 0x88, 0x19, 0x28, 0xE0, 0xE7, 0x14, 0xC0, 0x42, 0x89, 0x02, 0x01, 0x11,
                }
            },

            { EUniverse.Beta, new byte[]
                {
                    0x30, 0x81, 0x9D, 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01,
                    0x05, 0x00, 0x03, 0x81, 0x8B, 0x00, 0x30, 0x81, 0x87, 0x02, 0x81, 0x81, 0x00, 0xAE, 0xD1, 0x4B,
                    0xC0, 0xA3, 0x36, 0x8B, 0xA0, 0x39, 0x0B, 0x43, 0xDC, 0xED, 0x6A, 0xC8, 0xF2, 0xA3, 0xE4, 0x7E,
                    0x09, 0x8C, 0x55, 0x2E, 0xE7, 0xE9, 0x3C, 0xBB, 0xE5, 0x5E, 0x0F, 0x18, 0x74, 0x54, 0x8F, 0xF3,
                    0xBD, 0x56, 0x69, 0x5B, 0x13, 0x09, 0xAF, 0xC8, 0xBE, 0xB3, 0xA1, 0x48, 0x69, 0xE9, 0x83, 0x49,
                    0x65, 0x8D, 0xD2, 0x93, 0x21, 0x2F, 0xB9, 0x1E, 0xFA, 0x74, 0x3B, 0x55, 0x22, 0x79, 0xBF, 0x85,
                    0x18, 0xCB, 0x6D, 0x52, 0x44, 0x4E, 0x05, 0x92, 0x89, 0x6A, 0xA8, 0x99, 0xED, 0x44, 0xAE, 0xE2,
                    0x66, 0x46, 0x42, 0x0C, 0xFB, 0x6E, 0x4C, 0x30, 0xC6, 0x6C, 0x5C, 0x16, 0xFF, 0xBA, 0x9C, 0xB9,
                    0x78, 0x3F, 0x17, 0x4B, 0xCB, 0xC9, 0x01, 0x5D, 0x3E, 0x37, 0x70, 0xEC, 0x67, 0x5A, 0x33, 0x48,
                    0xF7, 0x46, 0xCE, 0x58, 0xAA, 0xEC, 0xD9, 0xFF, 0x4A, 0x78, 0x6C, 0x83, 0x4B, 0x02, 0x01, 0x11,
                }
            },

            { EUniverse.Internal, new byte[]
                {
                    0x30, 0x81, 0x9D, 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01,
                    0x05, 0x00, 0x03, 0x81, 0x8B, 0x00, 0x30, 0x81, 0x87, 0x02, 0x81, 0x81, 0x00, 0xA8, 0xFE, 0x01,
                    0x3B, 0xB6, 0xD7, 0x21, 0x4B, 0x53, 0x23, 0x6F, 0xA1, 0xAB, 0x4E, 0xF1, 0x07, 0x30, 0xA7, 0xC6,
                    0x7E, 0x6A, 0x2C, 0xC2, 0x5D, 0x3A, 0xB8, 0x40, 0xCA, 0x59, 0x4D, 0x16, 0x2D, 0x74, 0xEB, 0x0E,
                    0x72, 0x46, 0x29, 0xF9, 0xDE, 0x9B, 0xCE, 0x4B, 0x8C, 0xD0, 0xCA, 0xF4, 0x08, 0x94, 0x46, 0xA5,
                    0x11, 0xAF, 0x3A, 0xCB, 0xB8, 0x4E, 0xDE, 0xC6, 0xD8, 0x85, 0x0A, 0x7D, 0xAA, 0x96, 0x0A, 0xEA,
                    0x7B, 0x51, 0xD6, 0x22, 0x62, 0x5C, 0x1E, 0x58, 0xD7, 0x46, 0x1E, 0x09, 0xAE, 0x43, 0xA7, 0xC4,
                    0x34, 0x69, 0xA2, 0xA5, 0xE8, 0x44, 0x76, 0x18, 0xE2, 0x3D, 0xB7, 0xC5, 0xA8, 0x96, 0xFD, 0xE5,
                    0xB4, 0x4B, 0xF8, 0x40, 0x12, 0xA6, 0x17, 0x4E, 0xC4, 0xC1, 0x60, 0x0E, 0xB0, 0xC2, 0xB8, 0x40,
                    0x4D, 0x9E, 0x76, 0x4C, 0x44, 0xF4, 0xFC, 0x6F, 0x14, 0x89, 0x73, 0xB4, 0x13, 0x02, 0x01, 0x11,
                }
           },
        };


        public static byte[] GetPublicKey( EUniverse eUniverse )
        {
            if ( keys.ContainsKey( eUniverse ) )
                return keys[ eUniverse ];

            return keys[ EUniverse.Invalid ];
        }
    }
}
