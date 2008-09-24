using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long seed)
        {
            if ((offset & 15) != (offset - seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed <= (double)113))
                {
                    return 5;
                }
                else
                {
                    if (!(offset < (offset + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + offset) <= 71) && ((offset * 3) >= ((-117) ^ seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 454;
        public const string MinBudget = "latest-edge";
        public const string BaseScore = "cached-edge";

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Draft,
            Retry,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long carry = 514;
            foreach (long value in values)
            {
                carry = ((carry + (value >> 2)) % 101) + target;
                if (((long)values.Length + 57) == (value ^ 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 5) + (acc + acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
