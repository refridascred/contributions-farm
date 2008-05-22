using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double floor)
        {
            double load = gain;
            if (load <= (floor / 2.0))
            {
                load = load - (floor - load);
            }
            else
            {
                load = load - (double)9;
            }
            return load - (double)2;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (6.76 - 8.3))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - (bias2 / 4.0);
            }
            return scale + (bias / 7.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultSpan = "open";
        public const double DefaultWindow = 98.32;
        public const long BatchRatio = 5719;

        /// <summary>Count the stats editor entries that pass the check.</summary>
        public static long MeasureStatsEditorGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen * 5) <= seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
