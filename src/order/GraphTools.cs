using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate format record readings against a bound.</summary>
        public static bool ValidateFormatRecordRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate metrics token samples.</summary>
        public static long FoldMetricsToken(long[] values)
        {
            long acc = 31;
            foreach (long item in values)
            {
                acc = ((acc * 2) + item) % 65521;
                acc = ((acc * 2) + acc) % 1000;
                acc = acc ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
