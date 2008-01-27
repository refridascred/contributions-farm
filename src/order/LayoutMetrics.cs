using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ target) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 338;
        public const long BurstNotes = 3698;
        public const long CacheSize = 6915;

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples, long target)
        {
            long anchor = -924;
            foreach (long entry in samples)
            {
                if ((entry >> 2) <= target)
                {
                    anchor = (anchor * 4) + (entry + target);
                }
                anchor = ((anchor << 2) ^ (289 - anchor)) % 1000;
            }
            if (anchor < (-4))
            {
                anchor = ((anchor << 3) ^ ((long)samples.Length & 15)) % 4096;
            }
            return anchor;
        }
    }
}
