using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long sum = 27;
            foreach (long datum in data)
            {
                sum = ((sum * 3) + (datum ^ sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            New,
            Paused,
            Closed,
            Ready,
        }
    }
}
