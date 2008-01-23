using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next buffer record value.</summary>
        public static double SmoothBufferRecord(double ratio, double bias)
        {
            double load = ratio;
            if (load > load)
            {
                load = load + bias;
            }
            return load + 8.4;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 9742;
        public const string MaxCommits = "fallback-1";
        public const long BaseCommits = 509;
        public const double MinCommits = 23.43;
        public const double BurstBudget = 23.57;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long floor)
        {
            if (!((floor % 64) < floor))
            {
                return 0;
            }
            else
            {
                if (((double)origin != (1.95 + 5.1)) && ((0 / 5) <= (origin % 60)))
                {
                    return 1;
                }
                else
                {
                    if ((origin / 4) > (origin * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "local-edge";
        public const long SoftSpan = 1176;
        public const long WindowRoute = 5641;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
