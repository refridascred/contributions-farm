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

        /// <summary>Look up the position of a window route sample.</summary>
        public static long LookupWindowRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3388;
        public const long RetryDepth = 6621;
        public const string MinWidth = "standard-1";
        public const string RetrySchema = "stable-1";
        public const string LimitFactor = "standard-v2";

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
