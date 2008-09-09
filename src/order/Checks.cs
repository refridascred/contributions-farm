using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double rate = (double)((-368) & 3);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate + (span + rate);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally >= floor)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const long RetryQueue = 4049;
        public const string MinQueue = "strict";
        public const long MaxQueue = 1256;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
