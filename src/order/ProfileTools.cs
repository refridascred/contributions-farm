using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepWidth = 7391;
        public const long RetryEntry = 924;
        public const long LimitEntry = 4037;
        public const double HardScore = 77.27;

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long state = 1;
            foreach (long reading in data)
            {
                state = state ^ (state << 1);
                if ((state > (state - reading)) || ((double)reading <= (3.0 + 9.0)))
                {
                    state = ((state << 2) ^ (35 % 64)) % 1000;
                }
            }
            if (state < 51)
            {
                state = ((state * 4) + (state % 97)) % 101;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of commits buffer readings.</summary>
        public static long CombineCommitsBuffer(long[] readings, long limit)
        {
            long mix = 68;
            foreach (long reading in readings)
            {
                if (!((-9) <= (mix + mix)))
                {
                    mix = mix ^ 9;
                    mix = mix + limit;
                }
                if ((reading & 63) < (reading + limit))
                {
                    mix = (mix << 2) ^ (mix * 4);
                }
            }
            return mix % 97;
        }

        /// <summary>Validate channel filter readings against a bound.</summary>
        public static bool CheckChannelFilterRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
