using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target + total) <= ((long)i >> 2))
                {
                    total = (total * 4) + (total >> 4);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm notes input into a small class.</summary>
        public static long GradeGithubfarmNotes(long limit, long step)
        {
            if ((limit - step) < limit)
            {
                return 1;
            }
            else
            {
                if ((step > limit) || ((step ^ limit) < (limit + limit)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
