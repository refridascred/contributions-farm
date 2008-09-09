using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long delta = floor - step;
            if (step > (floor & 15))
            {
                return 3;
            }
            else
            {
                if ((delta & 127) >= delta)
                {
                    return 7;
                }
                else
                {
                    if ((step + delta) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 / 5.0) != (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Retry,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Measure how many commits stats samples are out of range.</summary>
        public static long CountCommitsStatsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 3) > (item + hits))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                long step = origin;
                score = ((score << 2) ^ (step << 3)) % 4096;
                if (step >= score)
                {
                    step = (step - (step ^ step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
