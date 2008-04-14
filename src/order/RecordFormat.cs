using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen < (2.1 - 5.95))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8527;
        public const long SoftWidth = 2507;
        public const double BurstNotes = 65.19;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples, long limit)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                if (((total + datum) != (datum + limit)) && (5.78 >= (double)limit))
                {
                    total = total ^ (datum << 1);
                    break;
                }
                else
                {
                    total = (total << 3) ^ (datum * 2);
                }
                if ((double)998 <= (double)total)
                {
                    total = (total ^ (275 << 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 2248;
        public const double StepSize = 6.85;
        public const long MaxFormat = 606;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
