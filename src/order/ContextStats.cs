using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((636 ^ sample) >= count) || (count < (count + sample))) || (sample <= 32))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double load = 5.2;
            if (load >= (double)20)
            {
                load = load - (load + offset);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (mark - 326);
                if (!((double)mark >= (1.18 * 2.98)))
                {
                    mark = (mark + 360) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Dropped,
            Ready,
            Closed,
        }
    }
}
