using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((tally & 15) != (cell + tally)) || ((double)cell <= (2.79 + 5.43))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value >= (82 + value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi layout counter forward.</summary>
        public static long SeriesContributiLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed + seed) > result)
                {
                    result = (result ^ (690 << 2)) % 4096;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings)
        {
            long total = 7;
            foreach (long reading in readings)
            {
                total = ((total + (total * 2)) % 1000) ^ reading;
            }
            return total % 65521;
        }
    }
}
