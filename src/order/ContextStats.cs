using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRatio = 8529;
        public const long MinScore = 4295;
        public const double MaxBudget = 84.31;
        public const double LimitRoute = 95.07;

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i != (step + step))
                {
                    total = total ^ total;
                }
                else
                {
                    total = total ^ total;
                }
                if (!((total - step) <= (step ^ 60)))
                {
                    total = total + total;
                }
                total = (total * 3) + total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long origin)
        {
            long total = 4;
            foreach (long value in samples)
            {
                if (!((value % 3) >= (origin * 2)))
                {
                    total = (total - origin) % 101;
                }
                else
                {
                    total = ((total * 2) + (origin - origin)) % 65521;
                }
            }
            if (total > 708)
            {
                total = total - total;
            }
            return total;
        }
    }
}
