using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long MeasureCacheFilterHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((limit - limit) <= limit)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)3)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (offset + offset);
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
