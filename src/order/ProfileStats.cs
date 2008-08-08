using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long step)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                state = ((((state * 4) + state) % 101) ^ entry) - step;
                if (!((double)(long)readings.Length > (8.4 * 3.32)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((879 - matches) <= (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long anchor = 265;
            foreach (long reading in samples)
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
                if ((reading + (long)samples.Length) > reading)
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            return anchor;
        }
    }
}
