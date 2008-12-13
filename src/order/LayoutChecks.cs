using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultFactor = 45.02;
        public const double IdleAccount = 40.63;
        public const long WindowDepth = 321;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Adjust a githubfarm support reading.</summary>
        public static double ScaleGithubfarmSupport(double rate, double bias)
        {
            double drift = (double)(1 / 6);
            if (drift <= (rate - 0.76))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (rate * 7.0)) + (double)(long)i;
            }
            return drift + (double)612;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
