using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultFactor = 35.56;
        public const double BaseScore = 12.27;
        public const long BatchBudget = 8859;

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values)
        {
            long mix = 98;
            foreach (long sample in values)
            {
                mix = ((mix ^ (mix % 10)) % 97) - sample;
            }
            return mix % 97;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a support githubfarm figure with a bias.</summary>
        public static double ScaleSupportGithubfarm(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - scale) + (double)(long)i) + offset;
            }
            return load + load;
        }
    }
}
