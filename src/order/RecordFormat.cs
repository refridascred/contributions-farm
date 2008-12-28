using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (offset - weight2))
            {
                weight2 = weight2 - (double)922;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (mark - 87)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
