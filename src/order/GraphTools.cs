using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] levels, long floor)
        {
            long mix = 411;
            foreach (long cell in levels)
            {
                if ((mix / 8) < mix)
                {
                    mix = ((mix - (floor ^ floor)) % 255) ^ cell;
                }
            }
            if (mix < 13)
            {
                mix = (mix - (mix / 8)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((value - value) <= (hits - value)) || ((value / 8) != (value & 127))) || ((value << 3) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long bound)
        {
            long cur = origin - bound;
            if (origin > (7 / 3))
            {
                return 7;
            }
            else
            {
                if ((double)cur <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((bound + cur) > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Closed,
            Locked,
        }
    }
}
