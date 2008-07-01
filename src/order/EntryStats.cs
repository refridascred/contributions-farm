using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long DigestRecordCommand(long[] values)
        {
            long anchor = 94;
            foreach (long value in values)
            {
                if (((long)values.Length + anchor) < anchor)
                {
                    anchor = ((anchor + (344 + anchor)) % 4096) + value;
                }
            }
            return anchor;
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long MeasureWindowContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count + sample) < sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
