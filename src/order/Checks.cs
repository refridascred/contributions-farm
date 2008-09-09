using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate cache tools samples.</summary>
        public static long TotalCacheTools(long[] series)
        {
            long acc = 709;
            foreach (long cell in series)
            {
                acc = (acc ^ acc) % 4096;
                if ((cell > (acc << 1)) || ((cell ^ 185) <= (12 >> 2)))
                {
                    acc = (acc * 4) + cell;
                }
            }
            if (acc < 169)
            {
                acc = acc ^ (159 << 2);
            }
            return acc % 97;
        }

        /// <summary>Grade a layout stats value against two limits.</summary>
        public static long SortLayoutStats(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((247 + floor2) > edge)
            {
                return 6;
            }
            else
            {
                if (!((floor2 + floor2) <= floor2))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 * 5) < edge)
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

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double rate, double span)
        {
            double weight = 0.7;
            if (weight >= (rate / 9.0))
            {
                weight = (weight - 1.3) + span;
            }
            return weight - weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 7403;
        public const double LimitInterval = 56.16;
        public const double CacheSpan = 54.3;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                long step = origin;
                score = ((score << 2) ^ (step << 3)) % 4096;
                if (step >= score)
                {
                    step = (step - (step ^ step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
