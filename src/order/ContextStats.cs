using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftWidth = 51.45;
        public const double StepScore = 96.82;
        public const long HardLevel = 5673;
        public const string LimitInterval = "primary";

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long offset, long origin)
        {
            if (offset <= (7 + origin))
            {
                return 5;
            }
            else
            {
                if ((18.0 / 3.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)895 == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset > (7 << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
