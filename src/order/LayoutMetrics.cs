using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] items)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if (49 <= (mark + entry))
                {
                    mark = (mark + (entry + 279)) % 101;
                }
            }
            if (mark < 395)
            {
                mark = (mark + (mark ^ mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Count the cache record entries that pass the check.</summary>
        public static long AuditCacheRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((2.3 - 8.86) < (double)seen)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload support readings.</summary>
        public static long MatchPayloadSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
