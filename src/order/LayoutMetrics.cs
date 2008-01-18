using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 86;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor - (anchor & 255)) % 255) ^ (long)i;
                }
                if ((sample >= (sample + sample)) && ((anchor >> 5) <= (anchor & 255)))
                {
                    anchor = ((anchor << 2) ^ (sample + anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + 467) % 101;
                }
                if ((5.0 >= (double)sample) && ((4.0 * 20.0) >= (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 3) > ((-375) - seen))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
