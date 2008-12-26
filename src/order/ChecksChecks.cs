using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if ((3 * 4) >= (anchor - (long)i))
                {
                    anchor = ((anchor << 2) ^ (anchor - (long)i)) % 101;
                    anchor = anchor - (target + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long origin)
        {
            long anchor = -74;
            foreach (long sample in samples)
            {
                if ((anchor >= 8) && ((origin - sample) < (sample % 3)))
                {
                    anchor = (anchor ^ 88) % 4096;
                }
                if (sample > (0 >> 2))
                {
                    break;
                }
            }
            if (anchor < 329)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }
    }
}
