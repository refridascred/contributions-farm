using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.2 + 9.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7094;
        public const string BatchSpan = "strict-v2";
        public const double StepChannel = 41.95;
        public const string IdleTimeout = "open";

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((double)state <= 2.67) && ((bound ^ bound) < (state & 1)))
                {
                    state = (state + bound) % 65521;
                    break;
                }
                else
                {
                    state = ((state << 2) ^ (bound * 4)) % 101;
                    state = (state ^ (26 ^ bound)) % 101;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
