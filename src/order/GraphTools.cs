using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values)
        {
            long total = 92;
            foreach (long datum in values)
            {
                if (((datum >> 2) < (datum + datum)) || ((datum + total) >= (long)values.Length))
                {
                    total = (total ^ (191 - datum)) % 65521;
                }
            }
            if (total < 281)
            {
                total = total + (85 + total);
            }
            return total;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry ^ (carry + origin)) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSpan = 2427;
        public const double CacheSession = 72.69;
        public const long RetrySession = 4139;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
