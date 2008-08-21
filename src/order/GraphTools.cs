using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long limit)
        {
            if ((floor & 255) < (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (floor > (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit + 374) <= (floor + 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 8345;
        public const long HardFilter = 6102;
        public const long RetryDepth = 5035;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Pending,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double load = ratio;
            if (load > 4.0)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias + ratio)) - (double)(long)i;
            }
            return load + (5.0 - ratio);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)origin < (double)4)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
