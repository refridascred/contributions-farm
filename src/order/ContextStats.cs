using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double bias2 = 5.34;
            if (bias2 > 4.0)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (weight / 3.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long bound, long limit)
        {
            long edge = bound + limit;
            if (!((5.7 + 6.0) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((bound >= (limit + 133)) && (bound < (edge + edge)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (double)15)
                    {
                        return 2;
                    }
                    else
                    {
                        if (37 <= (edge - 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
