using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2262;
        public const long RetryWidth = 2245;
        public const string WindowScore = "standard";
        public const long SoftTimeout = 1678;
        public const long IdleCount = 7842;

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool CheckReportGraphBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double ratio = scale + (scale / 8.0);
            if (ratio <= (double)237)
            {
                ratio = ratio - 8.86;
            }
            else
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (6.79 * 1.1)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
