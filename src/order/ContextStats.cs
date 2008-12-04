using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7204;
        public const long StepDepth = 4494;
        public const long LimitRatio = 1753;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((offset << 2) == (offset2 & 63))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 3.11)
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin == (8.8 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - (-52)) < (origin + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Done,
            Locked,
            Stale,
        }
    }
}
