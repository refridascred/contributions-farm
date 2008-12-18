using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)total > (double)(-502))
                {
                    break;
                }
                long bound = seed >> 3;
                if ((seed < (8 - bound)) || ((double)total < (9.34 * 6.66)))
                {
                    bound = (bound * 4) + ((long)i >> 5);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a format token counter forward.</summary>
        public static long StepFormatToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result << 3) ^ result) ^ (long)i2;
                    result = (result << 3) ^ origin;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first order payload entry that matches the target.</summary>
        public static long LocateOrderPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7344;
        public const double BurstBudget = 93.5;
        public const long WindowDepth = 8387;
    }
}
