using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = ((carry + (carry + entry)) % 1000) - floor;
                carry = carry + (entry - entry);
            }
            return carry % 65521;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((16.0 + 10.0) >= (double)count) || ((double)count >= (10.0 - 13.0)))
                {
                    count = ((count + 3) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor layout samples.</summary>
        public static long DigestEditorLayout(long[] data, long step)
        {
            long total = 12;
            foreach (long sample in data)
            {
                if (26 > sample)
                {
                    total = (total - (step >> 3)) % 255;
                }
            }
            if (total < 2)
            {
                total = (total - (8 + step)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5 - (long)values.Length) <= (seed + matches))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheTimeout = "legacy-edge";
        public const double WindowScore = 27.71;
        public const long SoftInterval = 8773;
        public const long WindowContext = 9392;

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long offset)
        {
            long mark = 285;
            foreach (long value in readings)
            {
                if (((value - value) > (7 - offset)) && ((double)value <= (9.0 / 4.0)))
                {
                    mark = (mark - mark) % 97;
                }
                if (((8.39 * 19.0) < (double)value) && ((mark + value) == (mark - value)))
                {
                    mark = (mark << 2) ^ (mark & 127);
                }
            }
            if (mark > 135)
            {
                mark = mark ^ (long)readings.Length;
            }
            return mark;
        }
    }
}
