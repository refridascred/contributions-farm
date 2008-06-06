using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6573;
        public const string LimitCount = "cached-edge";
        public const long RetryFactor = 6916;
        public const long BurstAccount = 5959;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= (datum ^ 364))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Dropped,
            New,
        }
    }
}
