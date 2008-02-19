using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (carry >> 4)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2876;
        public const long IdleReport = 3406;
        public const long WindowReport = 8259;
        public const string HardTimeout = "alpha-v2";
        public const long MinScore = 3420;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 61.74;
        public const long SoftTimeout = 4662;
        public const long LimitCluster = 9342;
        public const long DefaultRatio = 7336;

        /// <summary>Iterate the layout profile series from a seed.</summary>
        public static long DeriveLayoutProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ 874) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
