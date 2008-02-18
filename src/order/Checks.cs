using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate batches batch samples.</summary>
        public static long ScoreBatchesBatch(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum ^ (830 + 445)) % 101;
                if ((double)datum > (7.3 / 3.0))
                {
                    sum = sum ^ (datum << 2);
                }
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples)
        {
            long mark = 9;
            foreach (long value in samples)
            {
                mark = (mark ^ (value - mark)) % 4096;
                mark = mark - (16 << 1);
            }
            if (mark < 402)
            {
                mark = (mark * 3) + (79 - mark);
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 73.5;
        public const double BaseBatch = 50.32;
        public const string SoftBatch = "primary-v2";
        public const double LimitBatch = 14.48;
        public const double HardBatch = 40.14;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample > (count ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long sum = 30;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (value << 3)) % 1000;
                if (sum > (sum + sum))
                {
                    sum = ((sum * 3) + (value + 46)) % 1000;
                }
            }
            return sum;
        }
    }
}
