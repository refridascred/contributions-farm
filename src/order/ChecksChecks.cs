using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally >> 1) > (sample / 6)) || (((long)readings.Length << 2) < sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
