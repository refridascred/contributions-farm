using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit window account readings against a rule.</summary>
        public static long MeasureWindowAccountOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(seed >= (tally - tally)))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
