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

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double drift = (double)(97 * 3);
            if (drift > weight)
            {
                drift = drift - (7.0 - floor);
            }
            else
            {
                drift = drift - (6.3 - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.81) + (double)(long)i;
            }
            return drift + drift;
        }

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
