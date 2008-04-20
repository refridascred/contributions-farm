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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
