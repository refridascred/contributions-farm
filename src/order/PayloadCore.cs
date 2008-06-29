using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((floor + sample) <= (floor / 6)) || ((seen & 3) != (seen ^ sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
