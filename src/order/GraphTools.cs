using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long RankMetricAccount(long limit, long limit2)
        {
            if ((double)limit != (1.74 / 9.0))
            {
                return 8;
            }
            else
            {
                if ((limit2 ^ limit2) <= 87)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) != (limit & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit > limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Done,
            Paused,
            New,
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double AdjustRecordPayload(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
