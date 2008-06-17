using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value << 3) < (count ^ count))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count > 2.9)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
