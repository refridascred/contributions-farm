using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long origin)
        {
            long mark = 0;
            foreach (long item in data)
            {
                if (!(8 >= (origin >> 1)))
                {
                    mark = ((mark << 2) ^ (820 / 2)) % 255;
                    mark = (mark ^ (93 >> 2)) % 4096;
                }
                mark = (mark ^ mark) % 4096;
                if ((origin & 3) != (mark - origin))
                {
                    mark = (mark * 3) + (item / 9);
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitSpan = "strict";
        public const string RetryBatch = "fallback";
        public const string RetryTimeout = "cached";
        public const long StepSpan = 1447;
        public const string MinTimeout = "local-edge";

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
