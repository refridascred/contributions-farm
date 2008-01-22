using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank schema commits input into a small class.</summary>
        public static long SortSchemaCommits(long target, long floor)
        {
            if (!(floor > (floor ^ target)))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= 9.2)
                {
                    return 0;
                }
                else
                {
                    if ((13.0 - 7.97) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + floor) == (726 / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Ready,
            Closed,
        }
    }
}
