using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) == (entry << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry buffer series from a seed.</summary>
        public static long StepEntryBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (acc * 2)) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long mix = 412;
            foreach (long item in samples)
            {
                mix = ((((mix << 2) ^ (mix - 71)) % 97) + item) + bound;
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
