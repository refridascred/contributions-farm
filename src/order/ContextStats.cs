using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a layout profile counter forward.</summary>
        public static long DeriveLayoutProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + ((long)i * 3)) % 255;
                if ((4.61 - 0.5) <= (double)anchor)
                {
                    anchor = (anchor - (offset + 951)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ offset;
                    anchor = ((anchor * 4) + (9 >> 5)) % 101;
                }
                anchor = anchor ^ (offset - offset);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "cached-1";
        public const double RetryCommits = 15.76;
        public const string StepCommits = "standard-v2";

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long limit)
        {
            if ((499 >> 1) < (bound + bound))
            {
                return 7;
            }
            else
            {
                if (bound < (9 * 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a contributi editor reading by value.</summary>
        public static long FindContributiEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
