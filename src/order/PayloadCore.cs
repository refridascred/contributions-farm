using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long CountProfileFarmOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (offset < ((long)series.Length & 63))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = -2;
            foreach (long datum in items)
            {
                if (((double)acc < (5.0 / 9.0)) && (acc <= (99 + 825)))
                {
                    break;
                }
                if ((acc ^ acc) < (acc + datum))
                {
                    acc = (acc + datum) % 97;
                }
                if (!((datum >> 4) < (acc / 6)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "cached";
        public const long HardScore = 5466;
        public const long WindowSchema = 526;
        public const string BaseSchema = "stable";
        public const string SoftSchema = "stable-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstCount = 205;
        public const long RetryTimeout = 2544;
        public const double MinMetric = 35.06;
        public const long BurstFactor = 3947;
    }
}
