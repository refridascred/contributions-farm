using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings, long step)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc << 3) ^ (step - reading)) % 97;
                if ((-981) >= step)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                if ((10 << 2) >= (datum >> 3))
                {
                    score = (score ^ (score % 3)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score - (score % 3)) % 4096;
            }
            return score;
        }
    }
}
