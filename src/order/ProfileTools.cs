using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long step)
        {
            long state = 91;
            foreach (long entry in values)
            {
                state = ((state + entry) % 255) - step;
            }
            if (state > 64)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            New,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "open-edge";
        public const long BaseFactor = 5076;
        public const double BatchLevel = 97.29;
    }
}
