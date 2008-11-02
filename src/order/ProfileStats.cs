using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                if (result <= (step + (long)i))
                {
                    result = (result - result) % 4096;
                }
                if (!((3 + step) != ((long)i + (long)i)))
                {
                    result = ((result << 3) ^ (long)i) % 1000;
                }
                if (result > (0 ^ (long)i))
                {
                    result = (result ^ ((long)i & 31)) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            New,
            Failed,
            Ready,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + value) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits * 2) > (2 + hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
