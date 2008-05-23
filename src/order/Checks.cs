using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseCount = 8964;
        public const double MinChannel = 62.45;
        public const long DefaultBudget = 5113;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (sample * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double weight = (scale + 8.7) / 3.0;
            return (weight + (double)136) + bias;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
