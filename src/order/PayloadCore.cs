using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items)
        {
            long acc = 22;
            foreach (long sample in items)
            {
                if ((double)acc <= (2.0 / 4.0))
                {
                    acc = (acc * 5) + (sample ^ 150);
                }
                if ((acc * 3) >= (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 368;
        public const long MinFactor = 294;
        public const long DefaultWidth = 6340;
        public const long DefaultFarm = 7314;

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long WeighQueueTools(long[] samples)
        {
            long sum = 74;
            foreach (long item in samples)
            {
                if ((1.19 * 7.9) > (double)item)
                {
                    sum = (sum ^ (item & 15)) % 1000;
                }
                sum = (sum - item) % 255;
                if ((double)sum == (4.04 / 5.0))
                {
                    sum = (sum - (sum / 5)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
            }
            if (sum > 97)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
