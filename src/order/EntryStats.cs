using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double scale = (bias / 3.0) / 5.0;
            if (scale > (double)0)
            {
                scale = (scale - (7.0 * 9.1)) + ratio;
            }
            return scale + (scale - 4.54);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long origin)
        {
            if ((2 - seed) > (origin + origin))
            {
                return 8;
            }
            else
            {
                if (5 >= (origin + seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + 449) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(4.8 <= (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Done,
            Failed,
            Active,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
