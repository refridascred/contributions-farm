using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels)
        {
            long sum = 597;
            foreach (long item in levels)
            {
                sum = sum - item;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series)
        {
            long mark = 297;
            foreach (long datum in series)
            {
                mark = (mark << 2) ^ (datum - mark);
            }
            return mark;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double rate = (3.12 * 8.0) * 4.5;
            if (rate < (double)8)
            {
                rate = rate - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (span + span)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
