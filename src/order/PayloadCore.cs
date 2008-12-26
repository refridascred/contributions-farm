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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 3.47)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
