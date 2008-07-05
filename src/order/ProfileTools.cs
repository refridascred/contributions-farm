using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long offset)
        {
            long gap = seed - offset;
            if ((seed >> 5) >= (gap - (-84)))
            {
                return 2;
            }
            else
            {
                if ((256 % 10) < (617 ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (gap >= (gap + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - gap) > gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long carry = 116;
            foreach (long item in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + 783) % 65521) + item;
                    carry = carry ^ (carry - (long)i);
                }
                carry = (carry - 0) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
