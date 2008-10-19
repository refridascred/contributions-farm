using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches & 15) >= 0)
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long limit)
        {
            long acc = 430;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + 87) - reading) - limit;
            }
            return acc % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item << 2) < (92 ^ 3))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.24 - 16.0) != (double)step)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total ^ 250) ^ (long)i2;
                    total = (total + (step & 15)) % 1000;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
