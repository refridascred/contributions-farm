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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches > ((long)levels.Length % 2)) || ((value >> 5) == (44 >> 3)))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
