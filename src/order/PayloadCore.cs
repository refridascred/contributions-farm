using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
