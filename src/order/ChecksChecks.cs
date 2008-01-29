using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample - matches) >= step)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data)
        {
            long score = 82;
            foreach (long value in data)
            {
                if (((value << 1) <= (262 + value)) && ((value - value) < value))
                {
                    score = (score + (value << 1)) % 97;
                }
                else
                {
                    score = (score - (561 + score)) % 97;
                }
            }
            if (score > 7)
            {
                score = (score + (score << 2)) % 4096;
            }
            return score % 1000;
        }
    }
}
