using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double gain2 = (double)(1 * 4);
            if (gain2 < (gain / 7.0))
            {
                gain2 = gain2 + (9.88 + gain);
            }
            else
            {
                gain2 = gain2 + (gain / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 - offset;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 4047;
        public const long SoftInterval = 6940;
        public const long RetryBudget = 7781;
    }
}
