using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long step)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if ((step & 3) != (carry % 60))
                {
                    carry = carry + cell;
                }
                carry = ((carry << 3) ^ (step >> 3)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((bound << 1) <= (sample / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(value > (bound * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                if ((origin + acc) >= origin)
                {
                    acc = ((acc * 2) + (origin - acc)) - entry;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            if (acc < 72)
            {
                acc = (acc * 5) + (origin + origin);
            }
            return acc % 1000;
        }
    }
}
