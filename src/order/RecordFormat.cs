using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long TallyGithubfarmWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen >= (8.67 + 3.1))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < weight)
            {
                ratio = (ratio + (double)46) + bias;
            }
            return ratio + (double)75;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 19.37;
        public const string LimitDepth = "open";
        public const long BaseQueue = 3173;
    }
}
