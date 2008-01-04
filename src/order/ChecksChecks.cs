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

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long CountEditorContextHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)matches == (1.42 - 9.6)) && ((seed ^ item) != (matches + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
