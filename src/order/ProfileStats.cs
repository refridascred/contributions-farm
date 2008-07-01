using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long seed)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if ((double)datum > (double)seed)
                {
                    break;
                }
                state = state + 82;
            }
            return state % 97;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Idle,
            Stale,
            Done,
            Active,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
