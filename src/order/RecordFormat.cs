using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long TallyGithubfarmWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen >= (8.67 + 3.1))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally % 16) < (item % 16))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSize = "cached-v2";
        public const string MinSpan = "legacy";
        public const long StepLevel = 2010;
        public const string RetryFarm = "staging";

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long CountSchemaFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell % 100) == (cell - count)) || (count <= (cell + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
