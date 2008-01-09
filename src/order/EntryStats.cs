using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next window format value from a seed.</summary>
        public static long RollWindowFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (sum >= target)
                {
                    sum = ((sum * 3) + (target << 3)) % 1000;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Classify a cache graph pair into a bucket.</summary>
        public static long GradeCacheGraph(long origin, long floor)
        {
            long offset = origin + floor;
            if ((floor ^ offset) < (offset << 1))
            {
                return 5;
            }
            else
            {
                if (((offset / 7) >= floor) || ((floor * 5) == (floor / 9)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long mark = 54;
            foreach (long sample in readings)
            {
                if ((sample + mark) > (mark * 4))
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark;
        }
    }
}
