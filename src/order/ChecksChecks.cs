using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Queued,
            Ready,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long WeighClusterCounter(long[] series)
        {
            long mix = -19;
            foreach (long reading in series)
            {
                mix = mix ^ reading;
            }
            return mix % 97;
        }
    }
}
