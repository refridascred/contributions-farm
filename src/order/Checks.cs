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

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 7587;
        public const long BatchCommits = 404;
        public const long SoftCommits = 7739;
        public const double HardCommits = 81.18;

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
