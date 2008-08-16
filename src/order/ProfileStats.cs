using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long total = 121;
            foreach (long entry in levels)
            {
                if (((total + entry) > (946 >> 1)) || ((total & 3) <= 13))
                {
                    total = (total ^ (87 ^ total)) % 97;
                }
                else
                {
                    total = ((total * 4) + (30 / 4)) % 255;
                }
            }
            if (total < 946)
            {
                total = (total << 2) ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long CountEntryProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry > (step + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
