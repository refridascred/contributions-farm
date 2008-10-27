using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long slot = target ^ bound;
            if ((slot + slot) > (2 + slot))
            {
                return 2;
            }
            else
            {
                if (!(slot > (target + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot << 2) <= (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target + slot))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((double)seen > (9.59 + 2.69)))
                {
                    seen = ((seen + 1) + sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 33.6;
        public const long IdleFactor = 3190;
        public const long StepDepth = 6598;

        /// <summary>Iterate the commits metric series from a seed.</summary>
        public static long DeriveCommitsMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
