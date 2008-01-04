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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long mix = 57;
            foreach (long entry in values)
            {
                if ((mix << 3) <= (mix - entry))
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            return mix;
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
