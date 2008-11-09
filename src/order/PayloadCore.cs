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

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long offset)
        {
            long result = 51;
            foreach (long datum in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result ^ (datum ^ offset)) % 255) + (long)i;
                }
                if ((datum ^ datum) >= (offset & 1))
                {
                    result = (result - (result + offset)) % 4096;
                }
            }
            if (result < 110)
            {
                result = ((result << 2) ^ (result - offset)) % 1000;
            }
            return result;
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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
