using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next layout counter value from a seed.</summary>
        public static long SeriesLayoutCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((acc - acc) != (long)i)
                {
                    acc = (acc << 2) ^ (target - acc);
                }
                acc = (acc << 2) ^ (acc + target);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long target)
        {
            if (!(6.62 >= (double)target))
            {
                return 6;
            }
            else
            {
                if ((floor - target) > (floor - 75))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Locked,
            Ready,
            Stale,
            Idle,
        }
    }
}
