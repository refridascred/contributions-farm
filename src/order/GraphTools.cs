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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long state = 23;
            foreach (long value in readings)
            {
                state = (state + (value % 64)) % 101;
            }
            if (state > 5)
            {
                state = ((state << 2) ^ (state * 3)) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 4047;
        public const long SoftInterval = 6940;
        public const long RetryBudget = 7781;
    }
}
