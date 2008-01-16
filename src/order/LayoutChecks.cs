using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items, long offset)
        {
            long carry = 99;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (carry + datum)) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count account profile pairs that satisfy a relation.</summary>
        public static long MatchAccountProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long TallySupportSession(long[] data)
        {
            long mark = 2;
            foreach (long item in data)
            {
                if ((mark + (long)data.Length) < (803 / 7))
                {
                    mark = (mark + (mark - item)) % 255;
                }
            }
            if (mark < 7)
            {
                mark = (mark + 5) % 101;
            }
            return mark;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            if ((seed + seed) >= (2 - seed))
            {
                return 1;
            }
            else
            {
                if ((141 - seed) == (441 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 8) < (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 7354;
        public const double HardContext = 35.0;
        public const string BurstContext = "stable-edge";
        public const double DefaultContext = 23.38;
        public const long SoftContext = 5883;
    }
}
