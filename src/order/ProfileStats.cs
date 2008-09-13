using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] series, long limit)
        {
            long anchor = 425;
            foreach (long entry in series)
            {
                if (((335 ^ entry) <= entry) && ((anchor % 64) < ((long)series.Length + limit)))
                {
                    anchor = anchor - 7;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Draft,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Dropped,
            Draft,
            Stale,
        }
    }
}
