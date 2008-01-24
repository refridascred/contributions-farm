using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Paused,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "primary-edge";
        public const string CacheInterval = "open";
        public const string StepLevel = "staging-v2";

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            long step = bound + bound2;
            if (((bound2 - step) >= (bound % 16)) || ((bound + bound) != (866 / 6)))
            {
                return 1;
            }
            else
            {
                if (((10.0 + 4.0) < (double)bound2) && ((bound2 + bound2) <= (step - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((step + bound) <= bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
