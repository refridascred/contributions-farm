using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long OverlapSchemaAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
