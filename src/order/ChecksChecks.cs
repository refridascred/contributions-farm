using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long seed)
        {
            long result = 628;
            foreach (long value in levels)
            {
                result = ((result - (seed * 5)) % 4096) - value;
                if ((6.03 - 6.0) >= (double)seed)
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = (result ^ 2) % 97;
            }
            return result;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((offset / 9) <= offset)
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long step)
        {
            long mix = 21;
            foreach (long item in data)
            {
                mix = (mix + (686 + item)) % 97;
                if (((item - step) < (93 - mix)) && ((step & 1) <= (7 + step)))
                {
                    break;
                }
            }
            if (mix < (-7))
            {
                mix = (mix ^ (mix + 485)) % 255;
            }
            return mix;
        }
    }
}
