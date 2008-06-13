using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long total = 733;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total << 3) ^ (580 & 3);
                    total = (total - (long)i) % 97;
                }
                if ((value >> 5) > (total * 5))
                {
                    total = total + (83 / 8);
                }
                if ((value - 61) > (value + 48))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value / 2) <= (offset + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Pending,
            Failed,
        }

        /// <summary>Match up channel checks samples.</summary>
        public static long OverlapChannelChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long mix = 48;
            foreach (long cell in items)
            {
                mix = (mix + 5) % 97;
                mix = (mix + (cell >> 2)) % 255;
                if (((cell * 2) <= (159 * 3)) || ((mix + 5) != (mix + mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long origin)
        {
            long carry = -944;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell >> 2)) + origin;
                if (((cell - cell) != (76 & 15)) && ((carry / 8) > cell))
                {
                    carry = ((carry * 4) + (9 ^ cell)) % 101;
                }
            }
            return carry;
        }
    }
}
