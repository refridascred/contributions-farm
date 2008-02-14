using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long floor)
        {
            long delta = bound + floor;
            if ((bound < floor) && ((floor / 8) < (8 - floor)))
            {
                return 2;
            }
            else
            {
                if (delta > (0 >> 2))
                {
                    return 0;
                }
                else
                {
                    if (delta >= (delta >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor >> 1) >= delta)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 9.9;
        public const double MaxTools = 27.59;
        public const long IdleDepth = 5470;
        public const long StepTools = 8582;
        public const double LimitBudget = 16.73;

        /// <summary>Count profile metric pairs that satisfy a relation.</summary>
        public static long MatchProfileMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
