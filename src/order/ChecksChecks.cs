using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if (((score + score) >= (score / 3)) && ((sample / 4) > (score + score)))
                {
                    score = ((score * 3) + sample) % 255;
                }
            }
            if (score > 7)
            {
                score = (score << 2) ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Failed,
            Ready,
            Retry,
        }
    }
}
