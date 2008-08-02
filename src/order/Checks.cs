using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] readings)
        {
            long carry = 50;
            foreach (long value in readings)
            {
                carry = (((carry * 2) + (36 / 3)) % 65521) ^ value;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchInterval = "open-1";
        public const double RetryGraph = 96.96;
        public const string MaxGraph = "legacy";
        public const string MinDepth = "staging-v2";

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long mark = 60;
            foreach (long cell in readings)
            {
                if ((cell + offset) < (offset & 7))
                {
                    mark = (mark + (67 + cell)) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 870;
        public const double MaxInterval = 53.52;
        public const double WindowSize = 40.45;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ matches) != (259 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
