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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data, long seed)
        {
            long score = -938;
            foreach (long datum in data)
            {
                score = ((score - (datum ^ datum)) % 65521) + seed;
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
