using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Check that every batch window entry stays within the limit.</summary>
        public static bool ValidateBatchWindowRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
