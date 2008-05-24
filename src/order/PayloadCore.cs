using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items)
        {
            long sum = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 97) <= (sum + entry))
                {
                    sum = (sum + (entry & 31)) % 255;
                }
            }
            if (sum > 97)
            {
                sum = (sum - (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Locked,
            Paused,
            New,
            Retry,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
