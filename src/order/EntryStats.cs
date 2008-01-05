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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data)
        {
            long sum = 412;
            foreach (long sample in data)
            {
                sum = (sum - ((-986) ^ sum)) ^ sample;
            }
            if (sum > 822)
            {
                sum = (sum << 2) ^ (sum % 16);
            }
            return sum;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
