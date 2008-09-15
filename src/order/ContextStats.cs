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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-4) - sample) == (matches << 2))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
