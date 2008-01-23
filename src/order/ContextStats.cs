using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cluster payload samples.</summary>
        public static long DigestClusterPayload(long[] samples)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                if (!((sum / 5) < (entry * 3)))
                {
                    sum = sum ^ (sum << 2);
                }
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum ^ sum) - (long)i;
                }
                sum = (sum << 2) ^ entry;
            }
            if (sum > 13)
            {
                sum = ((sum * 4) + (sum & 127)) % 4096;
            }
            return sum;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
