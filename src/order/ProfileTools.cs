using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double scale = 2.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - 8.2) + (double)(long)i) - weight) - offset;
            }
            return scale - (double)8;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Dropped,
            Active,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 2452;
        public const long HardTimeout = 6282;
        public const long HardLevel = 6444;
        public const long DefaultDepth = 7211;
        public const long BatchStats = 6397;

        /// <summary>Validate metrics contributi readings against a bound.</summary>
        public static bool VerifyMetricsContributiBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
