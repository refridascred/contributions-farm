using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long origin)
        {
            long anchor = 496;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (origin - datum)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen % 64) >= (cell & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
