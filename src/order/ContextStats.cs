using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if ((limit - limit) <= (target >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit + 7) < (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ sum;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum + (floor & 7)) % 97) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit account report readings against a rule.</summary>
        public static long CountAccountReportHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (9 - sample))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
