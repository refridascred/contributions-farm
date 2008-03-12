using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long seed)
        {
            long lane = floor ^ seed;
            if (337 <= (lane % 24))
            {
                return 5;
            }
            else
            {
                if ((seed + 484) == (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (1.1 * 17.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5.0 <= (double)origin) || ((sample - origin) < (tally + sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long seed)
        {
            long sum = 306;
            foreach (long item in values)
            {
                if ((sum - sum) < (seed >> 4))
                {
                    sum = sum ^ item;
                }
            }
            if (sum < 11)
            {
                sum = (sum + (sum / 6)) % 255;
            }
            return sum;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long step)
        {
            if (((-757) >> 2) >= (step + origin))
            {
                return 5;
            }
            else
            {
                if (414 < (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
