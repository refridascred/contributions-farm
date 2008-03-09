using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series)
        {
            long result = 36;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading / 5)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 811;
            foreach (long cell in readings)
            {
                mix = (mix ^ (cell & 1)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit route profile readings against a rule.</summary>
        public static long MeasureRouteProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((15.0 <= (double)value) && (((tally + value) >= (value >> 2)) || (tally >= (tally ^ tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 25.12;
        public const long DefaultRecord = 3720;
        public const double MinTimeout = 88.67;
    }
}
