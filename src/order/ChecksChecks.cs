using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ (755 + 866)) % 97) ^ sample;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long sum = 4;
            foreach (long item in readings)
            {
                if ((19.0 / 5.0) < (double)item)
                {
                    sum = (sum * 2) + ((-45) / 2);
                }
                sum = ((sum << 3) ^ (sum - item)) % 4096;
                sum = (sum + (item - 886)) % 65521;
            }
            if (sum > 15)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 97;
        }
    }
}
