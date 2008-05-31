using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit buffer already readings against a rule.</summary>
        public static long MeasureBufferAlreadyMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length >= (4.7 - 6.9))
                {
                    seen = ((seen + 3) - sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
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
