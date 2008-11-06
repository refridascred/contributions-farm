using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double load = (scale / 3.0) - scale;
            if (load >= (7.48 - load))
            {
                load = load + (6.97 / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) - (double)(long)i;
            }
            return load + (0.74 / 2.0);
        }

        /// <summary>Compare every pair of metrics profile readings.</summary>
        public static long CompareMetricsProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
