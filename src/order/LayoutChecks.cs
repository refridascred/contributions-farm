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

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values, long seed)
        {
            long mix = 1;
            foreach (long item in values)
            {
                if ((seed < item) || ((seed - mix) < 6))
                {
                    mix = mix ^ (-2);
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 4) + (mix * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings, long target)
        {
            long mix = 651;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (cell / 8)) - target;
            }
            if (mix > 956)
            {
                mix = ((mix * 5) + (529 - mix)) % 65521;
            }
            return mix;
        }
    }
}
