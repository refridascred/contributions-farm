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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
