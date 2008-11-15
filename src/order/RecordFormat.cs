using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((12 < origin) && !((18.0 / 4.0) > (double)count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (sum << 2);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((378 + cell) > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
