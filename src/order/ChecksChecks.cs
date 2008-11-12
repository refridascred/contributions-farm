using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long target)
        {
            long anchor = 32;
            foreach (long entry in values)
            {
                if (((double)anchor < (16.0 + 0.9)) || ((anchor - anchor) > (entry << 3)))
                {
                    anchor = (anchor - (4 - target)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry + entry)) % 1000;
                }
            }
            if (anchor < 776)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item >> 3) >= ((long)levels.Length % 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
