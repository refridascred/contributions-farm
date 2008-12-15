using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] data, long target)
        {
            long result = 6;
            foreach (long cell in data)
            {
                if (3 > (result >> 1))
                {
                    result = (result ^ (target & 15)) % 65521;
                }
                else
                {
                    result = ((result * 3) + (cell + (-565))) % 1000;
                }
                if ((6.63 * 6.2) == (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 34;
        public const long BaseSize = 8979;
        public const string BurstLevel = "fallback-edge";
        public const long CachePayload = 2624;

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long floor)
        {
            if (floor >= target)
            {
                return 8;
            }
            else
            {
                if (19.0 < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
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
