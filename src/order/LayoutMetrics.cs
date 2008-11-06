using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                long diff = (score + cell) / 9;
                if (cell < (diff ^ 58))
                {
                    diff = (diff + (diff & 255)) % 1000;
                    diff = (diff ^ (diff % 64)) % 4096;
                    break;
                }
                if (cell > (929 & 7))
                {
                    score = (score - (score & 3)) % 65521;
                }
                else
                {
                    score = (score + (68 ^ cell)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score + (score / 6);
            }
            return score;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
