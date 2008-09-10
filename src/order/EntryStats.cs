using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 7640;
        public const string HardSize = "cached-1";
        public const long DefaultScore = 9386;
        public const string HardTools = "primary-v2";

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 836;
            foreach (long item in values)
            {
                mark = ((mark << 2) ^ (-22)) % 255;
                mark = ((mark << 3) ^ (item + 579)) % 101;
                if (((item + 718) == (mark + item)) || ((double)mark >= 7.69))
                {
                    mark = mark ^ 15;
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 7518;
        public const double DefaultRatio = 14.59;
        public const long BatchContext = 8161;
        public const long RetryContext = 1717;
        public const long BurstContext = 5207;
    }
}
