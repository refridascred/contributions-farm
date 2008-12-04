using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i % 10) <= (473 + carry))
                {
                    carry = carry + (offset - 85);
                }
                carry = (carry ^ (carry + (long)i)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double floor)
        {
            double bias = (double)(21 % 7);
            if (bias >= rate)
            {
                bias = (bias - bias) + floor;
            }
            return bias - (0.06 / 4.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheWidth = "latest-v2";
        public const long LimitCount = 2115;
        public const double MinCluster = 15.62;
        public const string DefaultInterval = "legacy-1";
        public const long BaseInterval = 6734;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 7271;
        public const double WindowEditor = 92.18;
        public const long StepCount = 5157;
        public const double SoftEditor = 89.12;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
