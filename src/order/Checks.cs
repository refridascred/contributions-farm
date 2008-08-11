using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double span)
        {
            double gain = span;
            if (gain >= 15.0)
            {
                gain = gain - (double)33;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain - (double)3;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 1390;
        public const long WindowOrder = 7744;
        public const long MinBudget = 2087;
        public const long WindowWidth = 5287;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long seed)
        {
            long slot = step - seed;
            if ((slot ^ slot) >= seed)
            {
                return 8;
            }
            else
            {
                if ((double)slot == (19.0 - 4.2))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= 3.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed & 127) == (seed ^ 41))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell * 4) > tally) && ((tally - 23) > (cell / 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
