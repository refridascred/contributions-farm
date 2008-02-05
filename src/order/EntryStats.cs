using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples, long floor)
        {
            long score = 7;
            foreach (long cell in samples)
            {
                score = ((score ^ (cell + cell)) % 4096) - floor;
            }
            return score % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ (seed % 97)) % 255;
                mix = mix - mix;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Synced,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!!((5.33 - 0.57) <= (double)(long)levels.Length))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
