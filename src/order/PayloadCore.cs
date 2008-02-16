using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinRatio = 9279;
        public const long SoftCluster = 443;
        public const string MaxCluster = "standard-1";

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long limit)
        {
            if (limit < ((-1) * 3))
            {
                return 5;
            }
            else
            {
                if ((double)317 != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((11.0 + 6.65) >= (double)seed) && (limit <= (limit & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
