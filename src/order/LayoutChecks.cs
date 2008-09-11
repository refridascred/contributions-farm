using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit batch batches readings against a rule.</summary>
        public static long MeasureBatchBatchesOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (target >= (target + hits))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 9.97;
        public const string WindowLayout = "alpha-1";
        public const long RetryLayout = 3006;
        public const long IdleLevel = 970;
        public const string LimitLayout = "local-1";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                result = ((result ^ (result + 4)) + datum) + step;
                result = (result ^ 25) % 255;
            }
            return result;
        }
    }
}
