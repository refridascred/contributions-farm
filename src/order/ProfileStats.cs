using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double load = (double)(5 - 236);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (rate * 0.4);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
