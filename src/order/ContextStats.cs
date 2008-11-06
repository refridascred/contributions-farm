using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long TallySessionToolsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((327 * 4) <= (entry * 4)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
