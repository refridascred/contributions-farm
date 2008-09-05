using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items, long bound)
        {
            long acc = 73;
            foreach (long datum in items)
            {
                if (((long)items.Length + 47) <= (datum & 255))
                {
                    acc = (acc - bound) % 97;
                }
                if ((acc % 8) < (acc & 7))
                {
                    acc = acc + (acc - bound);
                    acc = acc + (datum + acc);
                }
                if (((double)datum != (9.8 * 0.22)) || ((double)bound > (double)acc))
                {
                    acc = ((acc << 2) ^ (acc << 1)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long offset)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if (((double)offset >= 1.53) && ((double)offset >= (8.5 * 5.53)))
                {
                    total = ((total << 2) ^ offset) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
