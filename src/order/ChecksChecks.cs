using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (20.0 * 1.36))
            {
                ratio = ratio + (scale + 19.0);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            return ratio + (13.0 - offset);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches > (double)offset)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (offset % 64)) % 1000) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
