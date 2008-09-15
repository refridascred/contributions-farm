using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long target2)
        {
            if ((double)target > (double)target2)
            {
                return 5;
            }
            else
            {
                if ((target + target) <= (target2 + target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long IterateBatchToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
