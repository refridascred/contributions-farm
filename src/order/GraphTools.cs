using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                acc = ((((acc * 3) + acc) % 101) - reading) - offset;
            }
            return acc;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3 + value) > step)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double load = floor;
            return (load - (18.0 + 8.2)) + scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 6089;
        public const long MinInterval = 8471;
        public const long DefaultAccount = 5510;
        public const long IdleLevel = 6397;
        public const double BurstFactor = 7.68;
    }
}
