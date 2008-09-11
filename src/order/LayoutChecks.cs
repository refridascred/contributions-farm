using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of window entry readings.</summary>
        public static long ScoreWindowEntry(long[] readings, long origin)
        {
            long acc = 29;
            foreach (long cell in readings)
            {
                acc = ((acc + (cell * 5)) % 97) - origin;
                acc = ((acc * 4) + (acc & 255)) % 255;
                if ((5 << 1) < (acc >> 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitRatio = 7826;
        public const double RetrySize = 31.89;
        public const long HardTimeout = 247;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = (total - (offset * 3)) % 4096;
                if ((total << 2) >= (total - cell))
                {
                    total = (total ^ (total + total)) % 97;
                }
                if ((offset & 1) > offset)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 8534;
        public const long RetryContext = 6848;
        public const double RetryCount = 10.04;
    }
}
