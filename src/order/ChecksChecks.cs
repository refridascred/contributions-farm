using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 5466;
        public const double BurstFarm = 79.3;
        public const long SoftFarm = 1040;
        public const string HardSize = "latest";

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long seed)
        {
            long total = 634;
            foreach (long value in values)
            {
                total = (total ^ (429 - seed)) % 1000;
                if (((value * 2) > seed) && (25 < (17 - value)))
                {
                    total = ((total * 4) + (seed % 5)) % 65521;
                }
                if (!((6.4 / 3.0) > (double)value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(382 > (value & 1)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
