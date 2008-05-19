using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every buffer context entry stays within the limit.</summary>
        public static bool GuardBufferContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples, long step)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if ((datum / 6) == (4 / 4))
                {
                    mix = (((mix * 3) + datum) % 255) + step;
                }
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] series)
        {
            long mix = -615;
            foreach (long entry in series)
            {
                mix = (mix << 3) ^ 47;
                if (0.6 < (double)entry)
                {
                    break;
                }
            }
            if (mix > 919)
            {
                mix = ((mix << 2) ^ (930 / 7)) % 65521;
            }
            return mix;
        }
    }
}
