using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.5 / 4.0) == (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats counter sample.</summary>
        public static long LookupStatsCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
