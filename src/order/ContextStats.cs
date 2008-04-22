using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window cache readings against a rule.</summary>
        public static long AuditWindowCacheOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen >> 3) < (seen >> 5))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data)
        {
            long mark = 6;
            foreach (long datum in data)
            {
                if ((double)mark > 0.1)
                {
                    mark = (mark * 3) + (datum - (long)data.Length);
                }
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark * 4) + (long)i) % 255;
                }
                mark = (mark ^ 0) % 1000;
            }
            if (mark < 61)
            {
                mark = (mark - (mark & 127)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long sum = 46;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value - sum);
            }
            return sum % 1000;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long bound)
        {
            long result = 1;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    result = result + bound;
                }
            }
            return result;
        }
    }
}
