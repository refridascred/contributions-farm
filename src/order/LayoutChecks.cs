using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two account report measurements.</summary>
        public static double AdjustAccountReport(double ratio, double span)
        {
            double rate = (8.4 * 1.51) - ratio;
            if (rate > (ratio + rate))
            {
                rate = rate + (ratio + span);
            }
            else
            {
                rate = rate + (span * 0.5);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + 1.5)) + (double)(long)i;
            }
            return rate + (rate + ratio);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches / 3) != (datum + datum)) && ((double)datum >= (double)6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
