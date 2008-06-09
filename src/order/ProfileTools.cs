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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6830;
        public const long MaxGraph = 5773;
        public const long RetryInterval = 9149;

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
