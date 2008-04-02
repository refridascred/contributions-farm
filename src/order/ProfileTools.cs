using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (3.26 + 13.0))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every already batches entry stays within the limit.</summary>
        public static bool GuardAlreadyBatchesBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
