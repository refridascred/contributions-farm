using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 2599;
        public const long LimitChecks = 3359;
        public const long IdleChecks = 3474;
        public const long DefaultChecks = 5122;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Synced,
            Done,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((1.49 + 3.56) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - limit2) < limit)
                {
                    return 3;
                }
                else
                {
                    if (84 > limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 % 10) < (limit2 & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
