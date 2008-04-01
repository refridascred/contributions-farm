using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long offset)
        {
            long anchor = 9;
            foreach (long sample in data)
            {
                if ((7.32 + 4.6) > (double)anchor)
                {
                    anchor = (anchor + (offset & 127)) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of payload format readings.</summary>
        public static long OverlapPayloadFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long MeasureWindowChannelOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (51 < (count / 7))
                {
                    count = ((count + 3) - datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long MeasureReportMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (23 <= (value + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
