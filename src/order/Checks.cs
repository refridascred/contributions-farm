using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long floor)
        {
            if (floor <= (floor + 0))
            {
                return 0;
            }
            else
            {
                if ((double)7 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((19.0 + 10.0) != (double)offset) && ((7.28 * 6.2) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor / 6) != (floor & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((3 - sample) >= (8 >> 4))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((652 + seed) <= (7 + seed)) || ((count / 4) <= count))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Paused,
            Closed,
            Active,
        }
    }
}
