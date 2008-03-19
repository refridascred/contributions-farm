using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches > (394 - matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long DeriveContributiEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long MeasureProfileCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((double)tally != (5.6 * 11.0)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
