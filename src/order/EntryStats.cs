using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long MeasureStatsCacheOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= target)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long sum = 0;
            foreach (long item in series)
            {
                sum = (sum ^ (sum % 8)) % 101;
                sum = sum + (item << 2);
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (sum + 17)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long MeasureMetricsCommandOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3 / 6) < (long)data.Length)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
