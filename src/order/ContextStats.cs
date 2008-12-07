using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every contributi channel entry stays within the limit.</summary>
        public static bool GuardContributiChannelLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((12.0 + 3.1) >= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long CountAccountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((6.45 * 18.0) > (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
