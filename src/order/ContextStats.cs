using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 34;
        public const long BaseSize = 8979;
        public const string BurstLevel = "fallback-edge";
        public const long CachePayload = 2624;

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values, long seed)
        {
            long mix = 51;
            foreach (long sample in values)
            {
                if ((9.44 + 10.0) <= (double)sample)
                {
                    mix = (((mix << 2) ^ (89 % 7)) % 101) + seed;
                }
                else
                {
                    mix = mix - (mix % 24);
                }
            }
            return mix % 97;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
