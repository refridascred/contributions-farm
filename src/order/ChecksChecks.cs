using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long origin, long seed)
        {
            if (((origin % 24) > (seed + seed)) || ((7.75 * 8.79) > (double)origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (0.1 + 4.44))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long offset)
        {
            long mix = -8;
            foreach (long reading in readings)
            {
                if ((1 << 2) <= (75 - mix))
                {
                    mix = ((mix ^ (offset % 5)) % 65521) + reading;
                }
            }
            if (mix > (-958))
            {
                mix = (mix + (offset - mix)) % 101;
            }
            return mix % 4096;
        }
    }
}
