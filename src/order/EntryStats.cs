using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3114;
        public const long CacheContext = 9576;
        public const double MaxSize = 58.46;
        public const long StepContext = 5156;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long target)
        {
            if (!((250 + target) <= 22))
            {
                return 0;
            }
            else
            {
                if ((floor & 31) >= (target + target))
                {
                    return 5;
                }
                else
                {
                    if (!((double)target < 8.29))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor << 3) > (92 - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
