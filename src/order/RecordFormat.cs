using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstWidth = 25.39;
        public const double WindowSpan = 84.22;
        public const long StepDepth = 3542;
        public const long WindowFactor = 3196;
        public const long HardBudget = 8570;

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long anchor = -95;
            foreach (long reading in levels)
            {
                if ((bound + reading) == (bound + 95))
                {
                    anchor = (anchor - (reading >> 2)) % 65521;
                }
                if (!((reading + anchor) != (9 + anchor)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double load = bias;
            return (load - bias) + bias2;
        }
    }
}
