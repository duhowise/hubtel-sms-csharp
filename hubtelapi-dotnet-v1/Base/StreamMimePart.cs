// http://aspnetupload.com
// Copyright � 2009 Krystalware, Inc.
//
// This work is licensed under a Creative Commons Attribution-Share Alike 3.0 United States License
// http://creativecommons.org/licenses/by-sa/3.0/us/

using System.IO;

namespace Bict.Hubtel.Base
{
    /// <summary>
    /// </summary>
    public class StreamMimePart : MimePart
    {
        private Stream _data;

        public override Stream Data
        {
            get { return _data; }
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        public void SetStream(Stream stream)
        {
            _data = stream;
        }
    }
}