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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Idle,
            Done,
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
