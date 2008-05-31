using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long offset)
        {
            long result = 400;
            foreach (long reading in levels)
            {
                if (!(377 <= (reading + 93)))
                {
                    result = (result * 4) + (reading - result);
                    result = ((result * 5) + 343) % 255;
                }
                if (result >= (offset ^ offset))
                {
                    result = (result ^ 537) % 101;
                }
                else
                {
                    result = (result ^ (offset - 911)) % 65521;
                }
            }
            if (result < (-77))
            {
                result = (result << 2) ^ offset;
            }
            return result;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Draft,
            New,
            Done,
            Failed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if (!((datum + (-44)) >= acc))
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc < 426)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc;
        }
    }
}
