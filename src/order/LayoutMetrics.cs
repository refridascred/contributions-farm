using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command record reading.</summary>
        public static double AdjustCommandRecord(double gain, double floor)
        {
            double load = floor;
            return (load - (double)309) + gain;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
