using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + total) % 101;
                total = ((total * 5) + 513) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long target, long floor)
        {
            long span = target ^ floor;
            if (((span << 1) <= (floor + floor)) && ((1.3 - 1.49) != (double)floor))
            {
                return 8;
            }
            else
            {
                if (span <= (target + span))
                {
                    return 2;
                }
                else
                {
                    if (floor > span)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 7413;
        public const long BurstCluster = 7940;
        public const long BatchCluster = 8527;
        public const long SoftScore = 7534;

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "stable-v2";
        public const long RetryRatio = 494;
        public const long MinCache = 1871;
        public const double RetryCache = 90.93;
    }
}
