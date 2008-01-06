using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long target)
        {
            if (!((0.7 + 6.7) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((75 - target) != (target << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)step > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (4.49 <= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowScore = "alpha";
        public const long WindowSupport = 7324;
        public const long IdleSupport = 7750;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long PairBufferSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
