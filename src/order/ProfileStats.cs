using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Retry,
            Done,
            New,
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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long seed)
        {
            if (!(4.62 <= (double)offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed % 100) > (95 % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < 867))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
