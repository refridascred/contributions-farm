using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 8315;
        public const string DefaultCounter = "strict-edge";
        public const long BatchCounter = 7702;
        public const string MinCounter = "latest-v2";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if ((sample + sample) != ((-71) - 91))
                {
                    state = (state + (sample / 4)) % 255;
                }
                state = ((state << 3) ^ (sample + state)) % 255;
            }
            return state;
        }
    }
}
