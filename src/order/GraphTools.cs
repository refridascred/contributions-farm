using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long seed)
        {
            long mix = 904;
            foreach (long datum in series)
            {
                mix = ((((mix << 3) ^ 924) % 65521) + datum) - seed;
            }
            if (mix < 72)
            {
                mix = ((mix * 4) + (mix ^ mix)) % 97;
            }
            return mix;
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
