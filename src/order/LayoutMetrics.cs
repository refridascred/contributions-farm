using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a editor report figure with a bias.</summary>
        public static double BlendEditorReport(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (double)6)
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio - floor)) - (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
