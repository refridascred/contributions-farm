using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
