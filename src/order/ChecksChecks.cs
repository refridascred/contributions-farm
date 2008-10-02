using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the filter schema entries that pass the check.</summary>
        public static long CountFilterSchemaHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)floor >= (double)entry) || (((floor >> 4) != (tally + tally)) && ((0.2 + 5.45) == (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((9 * 3) >= (entry - 369))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
