using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data, long target)
        {
            long score = 24;
            foreach (long entry in data)
            {
                score = (score - (target - target)) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
