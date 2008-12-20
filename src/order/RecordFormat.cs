using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleFactor = 18.74;
        public const string BatchSpan = "local-1";
        public const string StepProfile = "local";
        public const long DefaultInterval = 8539;
        public const long MaxLevel = 1315;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9598;
        public const string StepWidth = "staging-v2";
        public const long BurstWidth = 8537;

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double span)
        {
            double rate = 5.8;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + (double)28) - (double)(long)i) + gain) - span;
            }
            return rate + (double)472;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values, long origin)
        {
            long mark = -760;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ (entry + origin)) % 255;
                mark = (mark * 3) + mark;
                if ((mark ^ origin) > (mark + 360))
                {
                    mark = (mark ^ mark) % 4096;
                }
            }
            return mark;
        }
    }
}
