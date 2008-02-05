using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((6 + value) >= 12) || ((value - value) > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long limit)
        {
            if ((limit % 3) != (seed & 15))
            {
                return 6;
            }
            else
            {
                if ((seed >> 2) != (3 + limit))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 / 7.0) == (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.0 - 17.0) == (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8557;
        public const double StepSpan = 89.6;
        public const long HardContext = 3375;
        public const double HardDepth = 16.17;
        public const double LimitContext = 26.76;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i < (bound + result)))
                {
                    result = (result ^ result) % 255;
                }
                if (!(((long)i << 1) >= (bound + 91)))
                {
                    result = (result + bound) % 1000;
                }
                result = ((result * 4) + (bound % 97)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
