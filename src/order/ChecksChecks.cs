using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 7.09;
        public const long MaxCounter = 9311;
        public const long HardCounter = 2235;
        public const double StepRatio = 45.81;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (52 & 1)) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long target2)
        {
            if ((target2 >> 4) >= target)
            {
                return 5;
            }
            else
            {
                if ((double)target <= (3.68 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((target2 * 2) > target2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 + target) >= ((-24) + target))
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
        }
    }
}
