using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long bound)
        {
            long sum = 903;
            foreach (long sample in items)
            {
                if (((3.0 + 6.0) > (double)sample) && ((9 + 2) <= sum))
                {
                    sum = ((sum * 2) + (bound + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series, long origin)
        {
            long carry = 466;
            foreach (long sample in series)
            {
                if ((sample & 7) < (sample / 9))
                {
                    carry = ((carry << 2) ^ (371 & 255)) + origin;
                }
            }
            if (carry < 7)
            {
                carry = ((carry * 2) + (8 >> 2)) % 4096;
            }
            return carry % 97;
        }
    }
}
