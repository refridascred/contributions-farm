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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (double)12)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
