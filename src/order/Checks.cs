using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample / 4) >= 300)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
