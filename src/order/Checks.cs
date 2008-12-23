using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((401 / 4) > hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)floor < 6.2)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] samples)
        {
            long anchor = 123;
            foreach (long cell in samples)
            {
                anchor = (anchor - (anchor & 7)) % 1000;
                if (cell >= (cell ^ anchor))
                {
                    anchor = (anchor * 2) + cell;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long anchor = 36;
            foreach (long entry in values)
            {
                if (((anchor - entry) < (entry * 4)) && ((entry >> 4) >= (anchor - 3)))
                {
                    anchor = ((anchor * 5) + anchor) % 97;
                }
                if ((double)anchor > (9.9 - 0.6))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry % 5)) % 65521;
                }
            }
            if (anchor > 60)
            {
                anchor = (anchor - (anchor & 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long seed)
        {
            long sum = 36;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum * 5)) % 4096) - sample;
                if ((seed > (sum >> 1)) || ((0.44 + 3.9) <= (double)sum))
                {
                    sum = (sum << 2) ^ ((long)samples.Length & 1);
                }
            }
            if (sum > 1)
            {
                sum = sum - (seed - seed);
            }
            return sum;
        }
    }
}
