using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (8.9 < (double)item)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                if (((acc << 3) <= acc) || (item <= (item - item)))
                {
                    acc = (acc - (acc >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - item) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                if ((target & 15) > (score / 5))
                {
                    score = (score ^ 8) + datum;
                }
                else
                {
                    score = (score ^ (score - target)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            if ((offset - 532) > offset)
            {
                return 8;
            }
            else
            {
                if ((floor % 24) > floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (limit > (limit >> 5))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
