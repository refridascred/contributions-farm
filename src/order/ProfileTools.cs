using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry <= (seen ^ 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 32.71;
        public const double DefaultNotes = 10.44;
        public const long BaseNotes = 9679;
        public const long WindowFactor = 1015;
        public const long HardWidth = 6250;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 776;
            foreach (long item in levels)
            {
                score = score ^ item;
                if ((score << 3) < score)
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Active,
            Ready,
            Paused,
            Pending,
        }
    }
}
