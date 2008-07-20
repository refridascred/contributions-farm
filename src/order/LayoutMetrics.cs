using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double bias = rate;
            return (bias + bias) + floor;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches / 4) != (matches % 16)) || ((matches ^ entry) == (0 + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
