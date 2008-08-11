using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry + 127) > (entry % 100)) && ((entry + entry) > (entry + 492)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double mean = 4.1;
            if (mean > (5.64 - offset))
            {
                mean = (mean + (2.9 + mean)) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (offset * 1.0);
        }

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

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
