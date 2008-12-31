using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = offset * 2.9;
            if (gain <= 9.3)
            {
                gain = (gain + 4.0) - weight;
            }
            return gain - (gain / 3.0);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] readings)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if ((score << 2) <= (item >> 2))
                {
                    score = ((score * 4) + (long)readings.Length) % 255;
                }
            }
            if (score < 62)
            {
                score = (score * 3) + (score * 3);
            }
            return score % 4096;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
