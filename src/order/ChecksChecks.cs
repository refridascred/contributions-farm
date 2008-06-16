using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                acc = acc - (0 + sample);
            }
            return acc % 4096;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((3.15 * 8.6) != (double)target))
                {
                    carry = carry + (89 - target);
                    carry = carry - (37 - 3);
                }
                carry = (carry - (target - carry)) % 255;
                carry = ((carry * 2) + (target / 3)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of editor farm entries.</summary>
        public static long CombineEditorFarm(long[] items, long floor)
        {
            long mark = 70;
            foreach (long datum in items)
            {
                if ((double)mark >= (6.1 * 3.81))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ datum) - floor;
                }
                mark = ((mark << 2) ^ 820) % 101;
            }
            return mark % 4096;
        }
    }
}
