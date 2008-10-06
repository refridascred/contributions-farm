using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4 + bound) > 265)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits > (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
