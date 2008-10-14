using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate route channel samples.</summary>
        public static long ScoreRouteChannel(long[] readings)
        {
            long mix = 27;
            foreach (long value in readings)
            {
                if (((value + value) > value) || (1.4 < (double)mix))
                {
                    mix = (mix * 4) + (value % 2);
                }
                else
                {
                    mix = (mix + (value - value)) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = ((mix * 2) + (mix / 3)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
