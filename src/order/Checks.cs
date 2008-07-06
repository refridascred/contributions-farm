using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long floor)
        {
            if (((double)step != (11.0 + 8.3)) || ((step << 1) < (794 * 4)))
            {
                return 8;
            }
            else
            {
                if (!((860 << 3) == (step + step)))
                {
                    return 2;
                }
                else
                {
                    if ((step * 5) == (floor & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((0.49 * 6.17) != (double)reading) && ((double)reading <= (10.0 / 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5546;
        public const long StepCount = 1471;
        public const double CacheNotes = 93.03;
        public const long BaseWidth = 1977;

        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long TallyBatchesPayloadGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) < (8 / 7))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
