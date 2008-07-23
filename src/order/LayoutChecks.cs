using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Queued,
            New,
            Active,
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long WeighPayloadProfile(long[] data, long origin)
        {
            long mix = 729;
            foreach (long entry in data)
            {
                mix = (((mix << 3) ^ mix) + entry) + origin;
            }
            if (mix > 49)
            {
                mix = (mix << 2) ^ (475 % 16);
            }
            return mix;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Synced,
        }
    }
}
