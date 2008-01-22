using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long origin)
        {
            long slot = step + origin;
            if ((double)slot >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((step % 8) > (29 + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
