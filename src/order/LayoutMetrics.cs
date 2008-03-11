using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxLevel = 77.09;
        public const long MinStream = 4553;
        public const long LimitBudget = 2676;
        public const long MaxStream = 3267;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ (offset ^ score)) % 4096;
                score = score ^ (offset ^ offset);
                score = (score ^ (offset - offset)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
