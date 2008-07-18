using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings, long origin)
        {
            long carry = 66;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((((carry << 3) ^ (item * 2)) % 97) - (long)i) - origin;
                }
                carry = (carry + (item * 3)) % 4096;
            }
            if (carry < 71)
            {
                carry = (carry + ((-78) + carry)) % 4096;
            }
            return carry % 65521;
        }
    }
}
