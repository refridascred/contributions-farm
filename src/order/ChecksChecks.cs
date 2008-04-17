using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = total - (total << 3);
                total = ((total * 2) + cell) % 101;
            }
            if (total < 457)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
