using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = (mean - (scale - 9.51)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)2) + (double)(long)i;
            }
            return mean + (double)595;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardInterval = 2472;
        public const string BurstToken = "alpha-v2";
        public const double SoftLevel = 71.05;
        public const long LimitFactor = 9528;
        public const long WindowToken = 837;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Active,
            Queued,
            Pending,
            Synced,
        }
    }
}
