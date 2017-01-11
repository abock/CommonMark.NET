namespace CommonMark.Syntax
{
    /// <summary>
    /// Contains additional data for heading elements. Used in the <see cref="Block.Heading"/> property.
    /// </summary>
    public struct HeadingData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadingData"/> structure.
        /// </summary>
        /// <param name="level">Heading level.</param>
        /// <param name="setextLength">Length of the of the setext heading underline, if applicable.</param>
        public HeadingData(int level, int setextUnderlineLength = 0)
        {
            Level = level <= byte.MaxValue ? (byte)level : byte.MaxValue;
            SetextUnderlineLength = setextUnderlineLength <= byte.MaxValue ? (byte)setextUnderlineLength : byte.MaxValue;
        }

        /// <summary>
        /// Gets or sets the heading level.
        /// </summary>
        public byte Level { get; set; }

        /// <summary>
        /// Gets or sets the length of the setext heading underline.
        /// </summary>
        public byte SetextUnderlineLength { get; set; }
    }
}
