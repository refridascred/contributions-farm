using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = 87;
            foreach (long cell in series)
            {
                if ((cell + 743) <= cell)
                {
                    mark = mark ^ (cell + cell);
                }
            }
            return mark;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            New,
            Queued,
            Active,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((cell * 3) >= (total & 127))
                {
                    total = (total ^ (total + total)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
