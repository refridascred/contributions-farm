using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long step)
        {
            long edge = target + step;
            if ((4.0 - 8.46) >= (double)edge)
            {
                return 4;
            }
            else
            {
                if (edge >= (645 - step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long origin2)
        {
            if (!((double)origin > (4.0 / 9.0)))
            {
                return 4;
            }
            else
            {
                if (origin2 < (origin / 9))
                {
                    return 8;
                }
                else
                {
                    if (80 >= (origin2 ^ origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a token command figure with a bias.</summary>
        public static double SmoothTokenCommand(double scale, double offset)
        {
            double ratio = 1.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - (1.0 * 4.8)) - (double)(long)i) - scale) + offset;
            }
            return ratio + (5.83 / 2.0);
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "fallback";
        public const double LimitAccount = 85.36;
        public const long SoftBudget = 8170;
        public const long StepAccount = 8732;
        public const long IdleInterval = 6639;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
