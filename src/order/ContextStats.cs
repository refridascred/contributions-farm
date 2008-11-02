using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4848;
        public const double IdleStats = 8.5;
        public const long BaseStats = 5223;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mix = 1;
            foreach (long value in readings)
            {
                if (((long)readings.Length >= mix) && ((value * 3) <= (mix + value)))
                {
                    mix = ((mix * 3) + (36 / 9)) % 1000;
                }
            }
            if (mix < 16)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Classify a command window pair into a bucket.</summary>
        public static long RankCommandWindow(long target, long floor)
        {
            long next = target - floor;
            if ((double)floor <= (6.53 + 8.8))
            {
                return 5;
            }
            else
            {
                if ((next < (next - next)) && ((65 - floor) < (target + next)))
                {
                    return 7;
                }
                else
                {
                    if ((8.5 + 4.58) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
