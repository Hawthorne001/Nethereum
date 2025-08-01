﻿using Nethereum.Hex.HexConvertors.Extensions;

namespace Nethereum.Util.ByteArrayConvertors
{
    public class HexToByteArrayConvertor : IByteArrayConvertor<string>
    {
        public byte[] ConvertToByteArray(string data)
        {
            return data.HexToByteArray();
        }

        public string ConvertFromByteArray(byte[] data)
        {
            return data.ToHex();
        }
    }

}
