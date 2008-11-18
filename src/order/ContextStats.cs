using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BatchTimeout = "fallback-v2";
        public const long StepLevel = 2120;
        public const string IdleInterval = "open-edge";
        public const double HardLevel = 78.98;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long step)
        {
            if ((double)origin > (11.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if (step <= origin)
                {
                    return 7;
                }
                else
                {
                    if ((step * 4) == (origin ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((17.0 * 3.39) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
