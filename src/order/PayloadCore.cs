using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSize = 4140;
        public const string BaseAlready = "primary-edge";
        public const string SoftFactor = "strict-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            New,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Dropped,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((0.49 / 3.0) <= (double)hits) && ((hits - reading) <= (286 / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
