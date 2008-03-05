using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - (mark % 7)) % 101;
                if (!((step << 1) > (mark - mark)))
                {
                    mark = (mark - step) % 101;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchFactor = "legacy-edge";
        public const long BaseCommand = 4451;
        public const long WindowBudget = 9821;

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long seed)
        {
            if ((seed + 95) != (seed * 3))
            {
                return 6;
            }
            else
            {
                if (((19.0 + 3.0) >= (double)step) || ((double)seed < (9.0 - 7.1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (step - step)) || ((seed << 1) > (74 * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
