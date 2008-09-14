using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long offset)
        {
            if ((double)step > (6.25 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((step - offset) >= (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset < 230) || ((double)offset == (2.6 + 10.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 3) < (offset + 86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Done,
            Active,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (total - seed)) % 97;
                total = (total ^ (total / 9)) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long ScoreAlreadyRoute(long[] readings, long bound)
        {
            long total = 683;
            foreach (long entry in readings)
            {
                if ((total + entry) >= (16 + entry))
                {
                    total = (total - (entry & 7)) - bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxBudget = 1.89;
        public const long CacheCounter = 8198;
        public const long MinWidth = 3297;
        public const long MinCounter = 2906;
        public const long DefaultBudget = 376;
    }
}
