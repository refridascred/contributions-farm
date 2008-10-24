using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long bound)
        {
            long state = 718;
            foreach (long entry in levels)
            {
                if ((bound * 3) > state)
                {
                    state = (state - (entry << 3)) % 4096;
                }
            }
            if (state < 32)
            {
                state = state + (bound ^ state);
            }
            return state % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
