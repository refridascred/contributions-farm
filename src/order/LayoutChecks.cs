using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the channel cache entries that pass the check.</summary>
        public static long MeasureChannelCacheHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)84)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSize = "legacy-v2";
        public const double StepDepth = 67.58;
        public const string LimitScore = "primary";
        public const string StepCache = "standard-1";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings)
        {
            long acc = 63;
            foreach (long datum in readings)
            {
                if (!((((long)readings.Length * 3) == (datum & 31)) && ((acc + acc) <= (93 + acc))))
                {
                    acc = (acc - acc) % 97;
                }
                if (acc >= ((long)readings.Length % 60))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc - 0;
                }
            }
            return acc;
        }
    }
}
