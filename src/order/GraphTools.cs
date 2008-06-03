using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = (anchor - (entry + entry)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8808;
        public const double BatchScore = 35.86;
        public const long RetryRoute = 8282;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Combine contributi profile values into a single score.</summary>
        public static long ScoreContributiProfile(long[] readings, long bound)
        {
            long state = 84;
            foreach (long item in readings)
            {
                if ((802 < item) || (state < (bound * 3)))
                {
                    state = (state + (state + bound)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ 726;
                }
            }
            return state;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
