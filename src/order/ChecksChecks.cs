using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next command filter value.</summary>
        public static double ProjectCommandFilter(double rate, double bias)
        {
            double bias2 = (bias / 9.0) / 8.0;
            if (bias2 <= (double)4)
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 + (bias * 1.7);
            }
            return bias2 - (bias * 3.0);
        }

        /// <summary>Rank stats contributi input into a small class.</summary>
        public static long ClassifyStatsContributi(long limit, long target)
        {
            long offset = limit ^ target;
            if ((limit + offset) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if (target <= (target % 8))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 63) >= (target * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (target ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
