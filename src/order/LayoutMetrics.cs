using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Synced,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 4) > (count % 3))
                {
                    count = ((count + 1) + item) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
