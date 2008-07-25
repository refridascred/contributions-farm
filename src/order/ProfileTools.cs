using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4493;
        public const long StepRatio = 4440;
        public const long BatchSupport = 3526;
        public const long SoftSupport = 7959;
        public const long WindowFactor = 2345;

        /// <summary>Count the schema buffer entries that pass the check.</summary>
        public static long MeasureSchemaBufferHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)bound >= (7.5 + 5.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (((carry - (carry * 2)) % 65521) ^ value) + limit;
            }
            return carry;
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long CountToolsCounterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (floor <= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
