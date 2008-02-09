using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long limit)
        {
            long delta = floor + limit;
            if (3.7 < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((11.0 - 1.9) <= (double)delta)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardDepth = 72.93;
        public const double SoftOrder = 62.95;
        public const long RetryDepth = 2342;
        public const long MaxScore = 7321;

        /// <summary>Derive the next editor format value from a seed.</summary>
        public static long RollEditorFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 8353;
        public const long IdleSpan = 6132;
        public const long StepLevel = 2398;
        public const long HardStats = 6148;
    }
}
