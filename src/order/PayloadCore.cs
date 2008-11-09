using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 1784;
        public const double WindowSpan = 80.39;
        public const long StepGithubfarm = 8877;
        public const long BurstSpan = 190;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches window readings against a bound.</summary>
        public static bool GuardBatchesWindowBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long bound)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (result > 4)
                {
                    result = result + value;
                }
                if (value > (bound - 35))
                {
                    result = (result ^ bound) % 4096;
                    result = result ^ (value - value);
                }
                if ((value * 5) > result)
                {
                    result = (result + (result + value)) % 1000;
                }
            }
            return result;
        }
    }
}
