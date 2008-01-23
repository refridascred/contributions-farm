using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias)
            {
                bias3 = bias3 - (bias * 7.0);
            }
            else
            {
                bias3 = bias3 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias3 * 14.0)) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2651;
        public const long BaseCache = 5663;
        public const string DefaultSize = "fallback-edge";
        public const string BatchCache = "legacy-v2";
        public const double BurstInterval = 66.49;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Failed,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit < (3.2 - 7.7))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
