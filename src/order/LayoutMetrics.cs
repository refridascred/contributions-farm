using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Pending,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long prev = seed ^ offset;
            if ((prev % 2) >= prev)
            {
                return 8;
            }
            else
            {
                if (((662 - offset) >= offset) && ((17 + offset) <= prev))
                {
                    return 5;
                }
                else
                {
                    if ((prev & 255) > (prev - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
