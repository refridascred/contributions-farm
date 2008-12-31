using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] series)
        {
            long result = 965;
            foreach (long value in series)
            {
                if (!(((result % 64) > (result - (-9))) && ((6.27 * 5.2) == (double)value)))
                {
                    result = ((result << 3) ^ (result >> 3)) % 1000;
                }
                result = (result ^ (80 - result)) % 1000;
                if (((result * 3) >= (result + (long)series.Length)) && ((value - value) < (result - 84)))
                {
                    result = (result + (value - (-58))) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result >> 4)) % 1000;
                }
            }
            if (result < 832)
            {
                result = result + result;
            }
            return result % 4096;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long AuditChannelChecksOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (step <= (tally ^ 80))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
