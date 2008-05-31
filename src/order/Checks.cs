using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cluster checks samples are out of range.</summary>
        public static long TallyClusterChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value <= (11.0 - 6.6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinTimeout = "open-v2";
        public const long BatchSize = 6811;
        public const long MaxCache = 5501;
        public const long IdleInterval = 9194;
        public const long LimitCache = 2001;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a checks notes pair into a bucket.</summary>
        public static long BucketChecksNotes(long offset, long limit)
        {
            if (((limit % 100) != (limit - offset)) || ((limit << 2) >= offset))
            {
                return 2;
            }
            else
            {
                if ((102 ^ offset) < (limit / 8))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + limit) != (offset * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema metric readings.</summary>
        public static long DigestSchemaMetric(long[] levels, long offset)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix + (mix / 5)) % 1000) + (long)i;
                }
                mix = (mix ^ (offset & 15)) % 4096;
                if ((mix ^ 566) > (offset ^ sample))
                {
                    mix = (mix << 3) ^ (87 * 2);
                }
            }
            return mix % 97;
        }
    }
}
