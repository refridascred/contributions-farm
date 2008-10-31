using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a batch schema sample.</summary>
        public static long FindBatchSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long TotalBatchCluster(long[] readings)
        {
            long mark = 234;
            foreach (long item in readings)
            {
                if (!(item <= (item & 127)))
                {
                    mark = (mark - 33) % 1000;
                }
                else
                {
                    mark = (mark * 4) + (item & 255);
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
