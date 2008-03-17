using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 408;
        public const long LimitBuffer = 7368;
        public const double CacheBuffer = 32.85;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long acc = 7;
            foreach (long datum in series)
            {
                acc = (acc - (datum / 2)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mark = 11;
            foreach (long cell in readings)
            {
                if ((cell - 2) < (cell & 63))
                {
                    mark = mark ^ 137;
                    continue;
                }
                mark = (mark - (cell - 1)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)tally != (18.0 + 7.13)) && ((45 + tally) <= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
