using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >> 2) != (seen ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long anchor = 899;
            foreach (long reading in levels)
            {
                anchor = anchor - (reading / 4);
                anchor = ((anchor << 2) ^ (anchor / 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultFactor = 1029;
        public const long BasePayload = 2046;
        public const long DefaultPayload = 9535;
        public const long BaseLevel = 8193;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Queued,
            Active,
            Locked,
            Closed,
        }
    }
}
