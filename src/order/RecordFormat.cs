using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next context queue value from a seed.</summary>
        public static long StepContextQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (((acc * 2) + (acc + acc)) % 1000) + (long)i2;
                }
                if ((bound + acc) <= (acc ^ bound))
                {
                    acc = acc - ((long)i & 3);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (offset - weight2))
            {
                weight2 = weight2 - (double)922;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (6.94 + 3.5))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
