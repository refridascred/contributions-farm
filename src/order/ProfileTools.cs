using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if (origin <= (786 ^ (-6)))
            {
                return 6;
            }
            else
            {
                if (5.2 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (0.22 - 0.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)4 >= (double)hits)
                {
                    hits = ((hits + 3) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data)
        {
            long total = 521;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (item / 4)) % 4096;
            }
            return total;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if (limit <= (6 & 1))
            {
                return 0;
            }
            else
            {
                if ((limit / 9) >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
