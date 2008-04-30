using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double mean = 3.0;
            if (mean < (double)302)
            {
                mean = (mean + 9.1) + offset;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - (scale + 9.6);
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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Size { get; set; }
            public long Token { get; set; }
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
