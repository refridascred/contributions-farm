using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long bound)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                anchor = ((anchor + (anchor - 0)) ^ reading) + bound;
            }
            return anchor % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitInterval = 21.78;
        public const long RetryRecord = 8422;
        public const long HardFactor = 4272;
        public const long WindowRecord = 1527;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((2.0 / 9.0) >= (double)entry) && (((entry << 1) <= entry) || ((matches >> 2) > (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
