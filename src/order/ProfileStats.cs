using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool GuardQueuePayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Iterate the farm buffer series from a seed.</summary>
        public static long StepFarmBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((sum & 63) == ((long)i % 2))
                {
                    sum = (sum + ((long)i - bound)) % 1000;
                }
                sum = (sum << 2) ^ (sum % 64);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
