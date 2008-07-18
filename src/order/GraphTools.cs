using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long TallyPayloadCounterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!!((matches + matches) >= ((long)values.Length >> 5)))
                {
                    matches = ((matches + 1) + sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Draft,
            Dropped,
            Idle,
        }
    }
}
