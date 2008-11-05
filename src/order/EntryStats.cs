using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (target + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleBudget = 3945;
        public const long HardCommits = 2380;
        public const long BaseSize = 8782;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary";
        public const double StepTimeout = 96.75;
        public const long LimitCount = 5603;
        public const string BurstMetric = "stable";

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i != (double)floor)
                {
                    anchor = (anchor - (anchor + (long)i)) % 65521;
                    anchor = anchor - (anchor & 1);
                }
                else
                {
                    anchor = (anchor ^ ((long)i % 97)) % 4096;
                }
                if ((floor - (long)i) <= (anchor << 1))
                {
                    anchor = anchor - (long)i;
                    anchor = (anchor + (floor + anchor)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
