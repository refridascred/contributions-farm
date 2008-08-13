using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of checks record readings.</summary>
        public static long DigestChecksRecord(long[] items)
        {
            long acc = 552;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc << 3) ^ (acc ^ item)) % 65521) + (long)i;
                }
                if ((acc / 2) == (acc ^ 2))
                {
                    acc = ((acc * 5) + ((long)items.Length / 4)) % 65521;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                result = (result + (result + 600)) % 101;
                if ((6.0 * 7.57) != (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length % 5) >= (hits >> 2))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long carry = 72;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (carry - 0))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry > 29)
            {
                carry = carry - (838 + 41);
            }
            return carry % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardTimeout = "cached";
        public const long StepWindow = 3540;
        public const long BatchScore = 7415;
        public const long LimitLevel = 4668;
    }
}
