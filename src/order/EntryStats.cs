using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long mark = 483;
            foreach (long sample in readings)
            {
                if ((offset & 255) >= (60 / 2))
                {
                    mark = ((mark - (offset / 7)) % 1000) ^ sample;
                }
            }
            return mark;
        }
    }
}
