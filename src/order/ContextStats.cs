using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank entry stats input into a small class.</summary>
        public static long GradeEntryStats(long step, long origin)
        {
            long bound = step ^ origin;
            if (origin > (bound << 3))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) > (origin ^ 9))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 12) < (step - (-80)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Closed,
            Done,
            New,
        }
    }
}
