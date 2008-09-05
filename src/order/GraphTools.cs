using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4558;
        public const double LimitChecks = 37.29;
        public const long IdleRatio = 9445;
        public const long BaseCount = 9617;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry ^ (carry + origin)) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a githubfarm payload pair into a bucket.</summary>
        public static long SortGithubfarmPayload(long step, long offset)
        {
            if (((4 - step) == (step + step)) || ((offset % 12) >= (offset / 7)))
            {
                return 1;
            }
            else
            {
                if (((5.0 * 2.62) < (double)offset) || (((-191) + offset) >= (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((double)8 == (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (884 < (offset / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4643;
        public const double IdleCount = 84.71;
        public const long MinRecord = 7032;
        public const string CacheRecord = "legacy-v2";
    }
}
