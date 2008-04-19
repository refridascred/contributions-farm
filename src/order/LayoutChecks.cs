using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a schema queue value against two limits.</summary>
        public static long GradeSchemaQueue(long bound, long step)
        {
            if ((1.0 + 9.2) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (2 < (step & 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((4 * 5) >= (step + 30))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long bound)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                if ((mix + datum) >= (-3))
                {
                    mix = ((mix << 2) ^ datum) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitFactor = 1.93;
        public const double BurstWindow = 56.72;
        public const long BaseSize = 250;
        public const string StepLevel = "staging-edge";
        public const long LimitBudget = 6468;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
