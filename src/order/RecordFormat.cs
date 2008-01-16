using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long floor)
        {
            long offset = limit - floor;
            if ((limit << 1) > (offset ^ floor))
            {
                return 8;
            }
            else
            {
                if (!((limit - 839) <= (limit + floor)))
                {
                    return 7;
                }
                else
                {
                    if (!(offset >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank already cluster input into a small class.</summary>
        public static long ClassifyAlreadyCluster(long origin, long step)
        {
            long step2 = origin ^ step;
            if (step >= (step ^ step))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((6 + step2) <= (origin << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2.0 / 9.0) != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate + (rate * 4.7)) - bias;
            }
            return rate + 4.81;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
