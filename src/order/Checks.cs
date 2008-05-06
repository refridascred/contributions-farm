using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ (mix << 3)) % 65521;
                mix = (mix ^ bound) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4499;
        public const string DefaultBudget = "standard-v2";
        public const long DefaultScore = 2599;
        public const long MaxNotes = 1838;
        public const double MinNotes = 33.62;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (108 <= (2 ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long bound)
        {
            if (((bound ^ floor) == (bound ^ 8)) || ((floor / 8) > floor))
            {
                return 4;
            }
            else
            {
                if ((0 - bound) > (bound & 63))
                {
                    return 0;
                }
                else
                {
                    if ((59 - bound) == (floor + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 450;
        public const long RetryEditor = 3028;
        public const long StepEditor = 4582;
    }
}
