using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Grade a githubfarm stream value against two limits.</summary>
        public static long GradeGithubfarmStream(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((double)bound < (3.0 / 7.0)) || ((bound ^ bound) < bound))
            {
                return 8;
            }
            else
            {
                if (offset > (-69))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound2 - (-7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Pending,
            Queued,
            Locked,
        }
    }
}
