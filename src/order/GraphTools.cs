using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long CountStatsNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 << 3) == (count / 7))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                mix = (((mix << 2) ^ (75 * 5)) - reading) - origin;
            }
            return mix % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long acc = 81;
            foreach (long entry in data)
            {
                if (entry < (269 - acc))
                {
                    acc = ((acc * 4) + (entry * 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ (entry * 2)) % 97;
                }
            }
            if (acc < 3)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 276;
        public const long BaseGraph = 579;
        public const long LimitWidth = 5962;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((seed - seed) < (7 % 97))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
