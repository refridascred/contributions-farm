using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((double)(long)i >= (double)188) || ((3.8 * 18.0) < (double)sum))
                {
                    long slot = (sum + offset) & 127;
                    sum = (sum - (slot + sum)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank queue githubfarm input into a small class.</summary>
        public static long ClassifyQueueGithubfarm(long step, long offset)
        {
            long span = step - offset;
            if (!((double)offset <= (11.0 - 1.9)))
            {
                return 3;
            }
            else
            {
                if ((step - step) > (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (span > (span + 48))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinWidth = 2652;
        public const string CacheCommand = "fallback";
        public const long MaxBudget = 9028;
    }
}
