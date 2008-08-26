using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long bound)
        {
            long sum = 82;
            foreach (long sample in levels)
            {
                if ((bound << 3) >= (sum + (long)levels.Length))
                {
                    long edge = sample;
                    sum = (sum << 3) ^ (bound + edge);
                    continue;
                }
                sum = sum + (sum - bound);
                if ((0.8 + 5.5) < (double)sum)
                {
                    sum = ((sum << 2) ^ ((-38) << 1)) % 101;
                }
            }
            if (sum > 3)
            {
                sum = (sum << 2) ^ (bound * 4);
            }
            return sum;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double bias = (double)(8 & 63);
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (gain * 16.0)) + (double)(long)i) + floor;
            }
            return bias - (double)104;
        }
    }
}
