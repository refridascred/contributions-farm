using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mix = -89;
            foreach (long entry in samples)
            {
                if ((65 * 2) > entry)
                {
                    mix = (mix + (long)samples.Length) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (entry / 5)) % 255;
                }
            }
            if (mix > 389)
            {
                mix = (mix - (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long WeighSchemaAlready(long[] readings, long limit)
        {
            long total = 873;
            foreach (long entry in readings)
            {
                if ((entry + 913) == (19 + (long)readings.Length))
                {
                    total = (total * 3) + limit;
                }
            }
            if (total < 920)
            {
                total = ((total * 4) + (limit * 5)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}
