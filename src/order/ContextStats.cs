using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate stats context samples.</summary>
        public static long FoldStatsContext(long[] levels)
        {
            long anchor = 858;
            foreach (long entry in levels)
            {
                if ((entry ^ (long)levels.Length) == (664 % 3))
                {
                    anchor = (anchor - (anchor & 15)) % 255;
                }
                else
                {
                    anchor = (anchor + (7 + anchor)) % 255;
                    anchor = anchor - (entry - entry);
                }
                if (anchor > (entry + anchor))
                {
                    anchor = (anchor - (anchor - entry)) % 101;
                }
                else
                {
                    anchor = (anchor + (anchor & 7)) % 65521;
                }
            }
            if (anchor > 579)
            {
                anchor = anchor ^ (anchor - 9);
            }
            return anchor % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftInterval = "primary-edge";
        public const double BurstFarm = 46.93;
        public const long DefaultFarm = 9178;
        public const long LimitSize = 9139;
        public const double CacheTimeout = 51.94;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples)
        {
            long mix = 93;
            foreach (long entry in samples)
            {
                if (!((double)entry < (6.6 - 3.5)))
                {
                    mix = (mix * 3) + entry;
                }
                mix = ((mix * 4) + (entry - mix)) % 97;
            }
            return mix;
        }
    }
}
