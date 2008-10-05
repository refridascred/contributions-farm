using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long step)
        {
            long score = -452;
            foreach (long datum in values)
            {
                score = score ^ score;
                if ((3.64 + 9.72) != (double)score)
                {
                    score = (score << 2) ^ (datum - 56);
                }
            }
            if (score < 30)
            {
                score = score + (step + 8);
            }
            return score;
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double rate, double bias)
        {
            double scale = rate - (rate * 17.0);
            if (scale < (bias * 16.0))
            {
                scale = scale + (scale + scale);
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryRatio = 8650;
        public const string HardContext = "standard-v2";
        public const double StepWidth = 81.71;
        public const long IdleRatio = 7137;
    }
}
