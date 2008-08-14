using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length << 3) == (count % 7)) || ((limit - 4) == (limit ^ count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxSpan = 36.34;
        public const long MaxDepth = 9658;
        public const long BurstInterval = 2075;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < (1.57 * 1.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                if (8.1 < (double)mix)
                {
                    mix = (mix + (long)i) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
