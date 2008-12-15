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

        /// <summary>Match up graph metrics samples.</summary>
        public static long MatchGraphMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
