﻿using WPFHexaEditor.Core.Bytes;

namespace WPFHexaEditor.Core
{
    /// <summary>
    /// BookMark class
    /// </summary>
    public sealed class BookMark
    {
        public ScrollMarker Marker { get; set; } = ScrollMarker.Nothing;
        public long BytePositionInFile { get; set; } = 0;
        public string Description { get; set; } = "";

        public BookMark()
        {
        }

        public BookMark(string description, long position)
        {
            BytePositionInFile = position;
            Description = description;
        }

        /// <summary>
        /// Return TBL string representation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({ByteConverters.LongToHex(BytePositionInFile)}h){Description}";
        }
    }
}