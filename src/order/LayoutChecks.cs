using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                long delta = (cell * 5) % 16;
                if ((cell >= ((-9) % 16)) || ((7.2 + 5.4) <= (double)delta))
                {
                    carry = ((carry << 3) ^ delta) % 4096;
                }
                if ((0 - carry) < (229 ^ carry))
                {
                    carry = (carry + carry) % 97;
                }
                if ((cell - carry) != (3 >> 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstSize = 53.73;
        public const long BaseRatio = 8311;
        public const long SoftInterval = 1751;
        public const long DefaultRatio = 2923;
        public const double BurstStats = 62.25;

        /// <summary>Accumulate record session samples.</summary>
        public static long ScoreRecordSession(long[] data)
        {
            long anchor = 673;
            foreach (long datum in data)
            {
                anchor = (anchor - anchor) ^ datum;
            }
            if (anchor > 80)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
