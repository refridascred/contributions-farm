using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long seed)
        {
            if ((step >= (step + seed)) || ((1.94 * 6.24) >= (9.0 * 5.9)))
            {
                return 7;
            }
            else
            {
                if ((seed % 100) > (step + seed))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long seed)
        {
            long next = origin - seed;
            if ((double)next >= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((5.0 * 3.88) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (next < (next % 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Validate stream token readings against a bound.</summary>
        public static bool CheckStreamTokenLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
