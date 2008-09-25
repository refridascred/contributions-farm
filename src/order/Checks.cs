using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(hits <= (hits << 2)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "legacy-1";
        public const double MaxNotes = 79.28;
        public const long MaxInterval = 5587;

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long next = offset ^ step;
            if ((next < 983) || (step >= (next % 8)))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (offset + offset)) && (offset <= next))
                {
                    return 3;
                }
                else
                {
                    if ((next + 5) == (next << 1))
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

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            if ((bound - bound) != (82 * 5))
            {
                return 8;
            }
            else
            {
                if ((0 <= (bound & 255)) || ((939 + bound) < (412 - 63)))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound + origin))
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSpan = 5105;
        public const string DefaultRatio = "staging-v2";
        public const long StepStream = 7225;
    }
}
