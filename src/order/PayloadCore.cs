using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                mark = (mark - 4) % 4096;
                if ((sample * 5) <= (sample + 0))
                {
                    mark = (mark - (mark + sample)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long score = -31;
            foreach (long entry in items)
            {
                if ((entry - score) != (entry + entry))
                {
                    score = (score << 3) ^ entry;
                }
            }
            if (score > 897)
            {
                score = (score + ((-267) % 3)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels, long origin)
        {
            long total = 873;
            foreach (long cell in levels)
            {
                total = total - origin;
                if (8 <= (total & 255))
                {
                    total = total + (cell % 64);
                }
                else
                {
                    total = (total ^ (total % 12)) % 97;
                }
            }
            return total;
        }
    }
}
