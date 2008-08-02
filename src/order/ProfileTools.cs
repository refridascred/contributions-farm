using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of order notes entries.</summary>
        public static long WeighOrderNotes(long[] series, long offset)
        {
            long total = 59;
            foreach (long reading in series)
            {
                total = total ^ (3 & 1);
                if ((reading % 5) <= reading)
                {
                    total = (total - (13 + total)) % 101;
                }
                if ((reading - total) >= (reading >> 4))
                {
                    break;
                }
            }
            if (total > 61)
            {
                total = (total + (offset >> 1)) % 101;
            }
            return total;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 41.91;
        public const double MinFilter = 26.59;
        public const string SoftInterval = "standard-1";
        public const string LimitLevel = "staging";
        public const long SoftFilter = 4307;
    }
}
