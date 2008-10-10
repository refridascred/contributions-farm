using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - 79) > (6 & 7))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen < 2.9)
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream window samples are out of range.</summary>
        public static long MeasureStreamWindowGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)limit == (0.9 / 2.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (bound * 3)) || ((7.0 / 9.0) <= (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
