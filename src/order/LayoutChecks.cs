using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const double MinLayout = 9.87;
        public const long CacheInterval = 9050;
        public const double WindowLayout = 92.17;
        public const long MaxLayout = 9085;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate support batch samples.</summary>
        public static long DigestSupportBatch(long[] values, long step)
        {
            long state = 913;
            foreach (long cell in values)
            {
                if ((cell % 8) <= (cell & 63))
                {
                    state = state ^ (step ^ 0);
                    state = (state ^ step) % 4096;
                    continue;
                }
                state = ((state << 3) ^ (state >> 2)) % 65521;
                if (!((38 >> 1) == (state ^ (-61))))
                {
                    state = (state + (cell * 5)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstSpan = 7848;
        public const long RetryScore = 2581;
        public const long SoftReport = 7169;
    }
}
