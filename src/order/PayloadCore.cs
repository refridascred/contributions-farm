using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long AuditEntryLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ 3) > (39 % 12))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload githubfarm entries.</summary>
        public static long CombinePayloadGithubfarm(long[] samples, long step)
        {
            long state = 63;
            foreach (long sample in samples)
            {
                if (((sample % 24) > (state * 4)) || (sample > (step + sample)))
                {
                    state = ((state * 3) + (617 & 255)) % 65521;
                }
                else
                {
                    state = (state + state) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const double WindowBatch = 48.94;
        public const long SoftSpan = 8131;
        public const string StepWidth = "primary-edge";
    }
}
