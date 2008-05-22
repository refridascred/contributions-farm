using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "primary-edge";
        public const long MaxCount = 2329;
        public const double CacheRatio = 6.39;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (bound & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long state = 39;
            foreach (long reading in data)
            {
                if (reading <= (state - reading))
                {
                    state = (state * 3) + reading;
                }
            }
            return state;
        }
    }
}
