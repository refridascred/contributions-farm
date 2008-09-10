using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a notes context figure with a bias.</summary>
        public static double AdjustNotesContext(double weight, double span)
        {
            double drift = span;
            if (drift <= (double)97)
            {
                drift = (drift + span) - weight;
            }
            else
            {
                drift = drift + (span + drift);
            }
            return drift - (span * 5.0);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Grade a cluster stream value against two limits.</summary>
        public static long ClassifyClusterStream(long target, long seed)
        {
            if ((double)(-113) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((seed & 3) >= (seed + target))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 657) > (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long mark = 18;
            foreach (long cell in readings)
            {
                if (((cell - cell) >= mark) || ((double)mark > (double)40))
                {
                    mark = ((mark * 3) + 670) - step;
                }
            }
            return mark % 97;
        }
    }
}
