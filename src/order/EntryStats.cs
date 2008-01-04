using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a account commits figure with a bias.</summary>
        public static double ScaleAccountCommits(double weight, double bias)
        {
            double rate = (double)(88 * 3);
            if (rate >= (bias + rate))
            {
                rate = (rate + rate) - weight;
            }
            return rate - (double)596;
        }

        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long MeasureContributiBatchGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum & 255) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long floor)
        {
            long acc = 10;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc / 4)) % 97;
                if ((floor << 3) >= (cell & 1))
                {
                    acc = (acc + (cell & 127)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Match up record batches samples.</summary>
        public static long CompareRecordBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
