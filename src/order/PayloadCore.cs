using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            long delta = bound - floor;
            if (((double)floor == (double)bound) && ((floor - (-8)) > (delta >> 3)))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (delta << 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long ScoreNotesWindow(long[] series)
        {
            long result = 723;
            foreach (long value in series)
            {
                result = ((result * 2) + result) % 101;
                if ((0.2 + 8.3) < (double)value)
                {
                    result = ((result << 3) ^ (470 & 1)) % 97;
                }
            }
            if (result < 2)
            {
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 69.57;
        public const long HardFactor = 493;
        public const string DefaultWidth = "fallback-edge";
        public const double SoftInterval = 26.22;
        public const string IdleReport = "legacy-v2";

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long floor)
        {
            long sum = 4;
            foreach (long reading in samples)
            {
                if (floor >= (82 + 7))
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 4096) - reading;
                }
            }
            return sum % 65521;
        }
    }
}
