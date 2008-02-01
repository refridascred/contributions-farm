using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if (((69 >> 3) < seed) || ((seed / 5) <= (7 & 1)))
            {
                return 5;
            }
            else
            {
                if (((seed - target) >= target) || (((-5) >> 5) < seed))
                {
                    return 0;
                }
                else
                {
                    if (target >= (6 + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - (limit << 1)) % 97;
                acc = acc + (limit << 1);
                acc = (acc ^ (limit >> 5)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long StepCount = 2358;
        public const long SoftFactor = 9409;
    }
}
