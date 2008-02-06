using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxWidth = 12.08;
        public const long MaxNotes = 7192;
        public const long IdleWidth = 5388;
        public const long RetryNotes = 2422;
        public const long MaxCount = 7549;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double load = scale - offset;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + offset)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long target, long origin)
        {
            long delta = target ^ origin;
            if (2 > (delta ^ delta))
            {
                return 8;
            }
            else
            {
                if (((-49) & 15) != (target % 12))
                {
                    return 0;
                }
                else
                {
                    if ((delta <= (origin + target)) && ((double)target < (double)4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)origin > (8.9 + 8.05)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
