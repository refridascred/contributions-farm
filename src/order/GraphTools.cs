using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double rate = (double)(553 << 1);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (bias - rate)) + (double)(long)i) + span;
            }
            return rate - (double)327;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long target, long bound)
        {
            if ((target >> 5) != (bound - target))
            {
                return 0;
            }
            else
            {
                if (bound <= (173 & 3))
                {
                    return 1;
                }
                else
                {
                    if (9.6 <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Queued,
            Stale,
            New,
            Pending,
        }
    }
}
