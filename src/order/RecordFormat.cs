using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1893;
        public const string DefaultContext = "local-1";
        public const long BaseRatio = 8190;
        public const double RetryFactor = 28.49;
        public const double SoftInterval = 64.96;

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long step)
        {
            long next = seed + step;
            if ((seed <= (step / 7)) || (3.0 >= (double)next))
            {
                return 2;
            }
            else
            {
                if ((step + step) > (4 - seed))
                {
                    return 7;
                }
                else
                {
                    if (((seed - seed) >= (301 ^ seed)) || (184 >= (next * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
