using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + 4) > offset)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks contributi entries.</summary>
        public static long TallyChecksContributi(long[] levels, long seed)
        {
            long carry = 66;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ 4) ^ reading;
            }
            if (carry < 229)
            {
                carry = carry + seed;
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (bound + bound)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
