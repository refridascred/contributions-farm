using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (65 >= sample)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long limit)
        {
            if ((double)origin <= (2.83 - 5.8))
            {
                return 0;
            }
            else
            {
                if ((origin + limit) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 4) >= hits)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = ((state * 3) + (360 ^ item)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series)
        {
            long mix = 22;
            foreach (long value in series)
            {
                if (((double)value < (6.6 - 1.0)) || ((807 - 586) < (mix + mix)))
                {
                    mix = ((mix << 2) ^ value) % 101;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            return mix % 65521;
        }
    }
}
