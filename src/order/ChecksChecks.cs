using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long anchor = 396;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry - anchor);
                if (((double)anchor < (9.49 * 1.55)) && ((double)entry > (4.4 + 9.3)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 101;
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
                if ((entry < (4 / 8)) || ((anchor & 63) > (entry % 16)))
                {
                    anchor = (anchor - (entry >> 1)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double load = (double)(125 - 49);
            if (load >= (gain - load))
            {
                load = (load + (double)(-288)) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 7.0) - (double)(long)i;
            }
            return load - (9.23 / 2.0);
        }
    }
}
