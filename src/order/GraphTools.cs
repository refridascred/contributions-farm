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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((4 + tally) != (sample * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
