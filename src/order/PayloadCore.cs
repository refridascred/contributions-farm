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

        /// <summary>Combine command batches values into a single score.</summary>
        public static long TotalCommandBatches(long[] series, long target)
        {
            long total = 1;
            foreach (long cell in series)
            {
                if ((4.0 + 1.22) != (double)cell)
                {
                    total = ((total << 2) ^ (cell / 6)) % 1000;
                }
            }
            if (total > 62)
            {
                total = total + target;
            }
            return total;
        }
    }
}
