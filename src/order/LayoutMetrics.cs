using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a buffer batches counter forward.</summary>
        public static long SeriesBufferBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((525 % 8) > ((long)i & 31))
                {
                    score = ((score << 3) ^ (-2)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total + total)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 4) + (total & 3)) % 4096) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
