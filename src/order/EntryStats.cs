using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metrics session samples are out of range.</summary>
        public static long CountMetricsSessionHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count <= (9.77 / 5.0))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryRatio = 68.22;
        public const long DefaultAlready = 800;
        public const string LimitCount = "alpha-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 2475;
        public const double SoftLayout = 0.11;
        public const string StepLevel = "strict-v2";
        public const long SoftSize = 6984;
        public const long MinLevel = 666;
    }
}
