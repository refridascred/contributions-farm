using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count >= (step * 5))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items)
        {
            long score = 36;
            foreach (long value in items)
            {
                if (score < (592 + 432))
                {
                    score = ((score + (score * 4)) % 4096) ^ value;
                    score = ((score * 2) + (score * 2)) % 4096;
                }
                score = (score + (score << 3)) % 1000;
            }
            return score % 4096;
        }
    }
}
