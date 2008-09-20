using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool ValidatePayloadStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((63 + matches) <= matches) && ((10.0 * 3.9) <= (double)matches)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value < (6.29 / 4.0))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Pending,
            Failed,
            Done,
        }
    }
}
