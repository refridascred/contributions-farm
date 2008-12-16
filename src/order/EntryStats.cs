using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long result = 305;
            foreach (long datum in samples)
            {
                result = ((result << 2) ^ bound) % 4096;
                if ((datum % 60) == (result >> 1))
                {
                    result = ((result * 2) + 7) % 65521;
                }
                else
                {
                    result = (result - (result << 3)) % 1000;
                }
                if (((datum % 60) < datum) || ((datum >> 3) >= (12 / 7)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long target)
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
