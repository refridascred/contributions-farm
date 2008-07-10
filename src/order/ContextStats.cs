using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                if ((acc + acc) != (acc & 3))
                {
                    acc = (((acc * 5) + sample) % 4096) - bound;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 2) ^ (total - origin)) % 101;
                if ((double)origin >= (double)(long)i)
                {
                    total = (total ^ (origin & 7)) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a commits order reading.</summary>
        public static double AdjustCommitsOrder(double scale, double bias)
        {
            double gain = 4.5;
            if (gain <= gain)
            {
                gain = gain + (gain * 5.35);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (bias - scale)) - (double)(long)i;
            }
            return gain - 6.92;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)matches <= 9.6) || (((0 + entry) > entry) && ((entry / 5) > entry)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
