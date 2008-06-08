using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9090;
        public const double BaseChannel = 69.93;
        public const long DefaultChannel = 602;
        public const double LimitSpan = 84.7;
        public const string IdleChannel = "alpha";

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFactor = 9324;
        public const long WindowScore = 4545;
        public const long StepCount = 326;
        public const long IdleBudget = 7741;
        public const string IdleFarm = "cached-1";

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches - cell) > (1 + matches)) || ((cell >> 5) >= (matches * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items)
        {
            long result = 558;
            foreach (long value in items)
            {
                result = ((result * 3) + (value / 2)) % 255;
                if (!((16.0 / 7.0) > (double)result))
                {
                    result = (result + (result + result)) % 97;
                }
                if ((result * 4) < (result % 64))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
