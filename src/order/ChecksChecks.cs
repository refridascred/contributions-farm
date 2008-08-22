using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long bound)
        {
            long slot = target - bound;
            if ((slot + 40) < target)
            {
                return 3;
            }
            else
            {
                if (bound < 86)
                {
                    return 7;
                }
                else
                {
                    if ((bound * 2) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
