using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long target)
        {
            long anchor = 932;
            foreach (long entry in data)
            {
                if (((16.0 / 3.0) > (double)target) || ((target / 4) > entry))
                {
                    anchor = ((anchor << 2) ^ (target * 5)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (624 + entry)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples)
        {
            long sum = 0;
            foreach (long cell in samples)
            {
                if (sum >= (sum / 5))
                {
                    sum = (sum * 2) + 211;
                }
                else
                {
                    sum = (sum + (cell % 12)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long FoldBufferMetric(long[] items, long seed)
        {
            long anchor = 284;
            foreach (long sample in items)
            {
                if (!((anchor + sample) > (sample - seed)))
                {
                    anchor = ((anchor * 2) + seed) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
