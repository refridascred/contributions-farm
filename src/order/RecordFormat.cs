using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many checks githubfarm samples are out of range.</summary>
        public static long CountChecksGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (0 + offset))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
