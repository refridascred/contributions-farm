using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleFactor = 9429;
        public const string RetryInterval = "latest-1";
        public const long DefaultQueue = 237;
        public const long BatchQueue = 6401;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)6 < (double)cell)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double drift = offset + offset;
            if (drift < drift)
            {
                drift = (drift - (offset - offset)) + ratio;
            }
            return drift + (4.0 / 2.0);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long mark = -9;
            foreach (long datum in series)
            {
                if ((8.1 - 11.0) < (double)bound)
                {
                    mark = (mark + (datum / 4)) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (datum * 4);
                }
            }
            return mark;
        }
    }
}
