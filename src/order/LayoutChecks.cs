using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 7408;
        public const long HardEditor = 1441;
        public const long BurstCount = 862;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            New,
            Closed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long sum = 15;
            foreach (long entry in series)
            {
                sum = (sum + sum) % 97;
                if ((66 ^ sum) >= (entry + entry))
                {
                    sum = (sum - (entry ^ entry)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) == (seen + entry))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Combine commits account values into a single score.</summary>
        public static long CombineCommitsAccount(long[] items, long offset)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = ((((anchor * 3) + anchor) % 1000) ^ value) - offset;
            }
            return anchor % 65521;
        }
    }
}
