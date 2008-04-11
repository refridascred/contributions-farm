using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values)
        {
            long acc = -9;
            foreach (long reading in values)
            {
                if ((reading << 2) <= (acc << 3))
                {
                    acc = acc ^ acc;
                }
                if (((double)reading == (6.75 / 2.0)) || ((double)acc != (4.0 * 12.0)))
                {
                    acc = acc ^ (acc & 3);
                }
            }
            if (acc < 6)
            {
                acc = (acc ^ (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 8108;
        public const long HardSpan = 6018;
        public const long WindowSpan = 956;
    }
}
