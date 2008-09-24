using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 3761;
        public const long CacheSupport = 6703;
        public const string IdleSupport = "legacy-1";
        public const long RetrySupport = 8669;
        public const long BurstSupport = 7670;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long seed)
        {
            if (!(step >= (seed ^ seed)))
            {
                return 2;
            }
            else
            {
                if (!(seed >= 35))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed > (8.43 - 5.76)) || ((step >> 5) <= (step & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((51 - step) <= (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account farm readings against a rule.</summary>
        public static long TallyAccountFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count << 3) >= 415) && !((count * 2) >= (count ^ value)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
