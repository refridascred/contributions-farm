using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a notes context pair into a bucket.</summary>
        public static long SortNotesContext(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((seed < (seed - step)) && ((2 + step2) < 9))
            {
                return 8;
            }
            else
            {
                if ((6.0 - 7.1) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Failed,
            Locked,
            Ready,
            Paused,
        }
    }
}
