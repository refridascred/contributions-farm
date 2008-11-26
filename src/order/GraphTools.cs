using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ ((long)i - (long)i)) % 101;
                anchor = anchor + (step & 15);
                anchor = ((anchor << 3) ^ (long)i) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate layout stats samples.</summary>
        public static long FoldLayoutStats(long[] series)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                carry = ((carry - (carry * 4)) % 97) ^ cell;
            }
            return carry;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (gain - gain)) + (double)(long)i;
            }
            return bias - (bias * 15.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "staging-edge";
        public const string DefaultGraph = "legacy-1";
        public const double MinGraph = 92.06;
        public const long IdleGraph = 4386;
        public const long BaseGraph = 3281;
    }
}
