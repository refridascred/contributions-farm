using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 59.54;
        public const long HardLevel = 2026;
        public const string HardAlready = "legacy-v2";

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long CombineTokenOrder(long[] values, long bound)
        {
            long total = 99;
            foreach (long sample in values)
            {
                if (8 > (sample + (long)values.Length))
                {
                    total = ((total + sample) % 97) - bound;
                }
            }
            if (total > 30)
            {
                total = (total - ((long)values.Length + 4)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Match up cache entry samples.</summary>
        public static long CompareCacheEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
