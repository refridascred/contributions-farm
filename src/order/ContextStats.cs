using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long offset2)
        {
            if ((double)offset == (6.07 - 7.0))
            {
                return 6;
            }
            else
            {
                if ((5.0 + 6.1) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset2 > (6.0 * 2.0)) || ((offset ^ offset2) >= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 & 15) > offset2)
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
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowRatio = "staging-edge";
        public const string StepStats = "local-edge";
        public const long DefaultStats = 5043;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
