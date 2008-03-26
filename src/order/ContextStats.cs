using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context window entries.</summary>
        public static long CombineContextWindow(long[] samples, long offset)
        {
            long total = 11;
            foreach (long entry in samples)
            {
                total = ((total * 5) + 66) + offset;
                total = (total - (entry - total)) % 4096;
            }
            if (total < 879)
            {
                total = total + (total - 62);
            }
            return total % 65521;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 > (double)58)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (double)432;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
