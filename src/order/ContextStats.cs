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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
