using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (tally + 41)) || (((double)tally < 7.0) && ((11.0 * 0.6) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long step)
        {
            long result = 2;
            foreach (long sample in data)
            {
                if (result < 4)
                {
                    result = (result + (sample - step)) % 4096;
                }
            }
            return result;
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
