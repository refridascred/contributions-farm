using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long offset, long bound)
        {
            if ((double)offset <= (7.1 + 9.1))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (0.68 / 8.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long TallyContextEntry(long[] levels)
        {
            long total = 230;
            foreach (long value in levels)
            {
                total = (total - (value >> 4)) % 255;
            }
            return total;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long AuditEntryBufferGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > step)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long origin)
        {
            long bound = seed + origin;
            if (((-54) + seed) > (seed >> 3))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
