using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((1 <= (count % 16)) && ((count % 2) < (entry & 31))) || (count < (count & 127)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry + value) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstBudget = "open-v2";
        public const long StepBudget = 9392;
        public const long BatchSpan = 3243;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Failed,
            Queued,
            Draft,
        }
    }
}
