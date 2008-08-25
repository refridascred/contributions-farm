using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((2.22 < (double)origin) && ((seed * 4) >= seed))
            {
                return 2;
            }
            else
            {
                if ((edge & 127) <= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.1 - 4.37) == (double)edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
