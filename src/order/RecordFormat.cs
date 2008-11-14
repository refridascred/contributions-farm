using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next account order value.</summary>
        public static double AdjustAccountOrder(double bias, double offset)
        {
            double mean = 3.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - offset) - (double)(long)i) - bias;
            }
            return mean + mean;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 1289;
        public const string MinFilter = "fallback-1";
        public const long BurstFilter = 4252;
        public const long MinInterval = 7981;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long floor)
        {
            if (((target - target) != (floor / 5)) && ((floor % 12) < floor))
            {
                return 1;
            }
            else
            {
                if (floor < (target % 97))
                {
                    return 3;
                }
                else
                {
                    if ((target & 63) < (-52))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
