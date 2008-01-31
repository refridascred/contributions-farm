using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >= (matches * 5)) || ((13.0 + 1.0) > (double)reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long offset)
        {
            long slot = limit ^ offset;
            if ((3 * 4) < (slot & 31))
            {
                return 5;
            }
            else
            {
                if ((offset <= (slot - 79)) && (((-840) + slot) != (slot + 315)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a channel support figure with a bias.</summary>
        public static double SmoothChannelSupport(double ratio, double bias)
        {
            double rate = (double)(485 % 16);
            if (rate < (bias + bias))
            {
                rate = (rate + (rate - rate)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - 9.7;
        }
    }
}
