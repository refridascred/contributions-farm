using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batches stream samples.</summary>
        public static long TotalBatchesStream(long[] readings)
        {
            long state = 492;
            foreach (long datum in readings)
            {
                state = (state << 3) ^ (50 ^ state);
                state = (state * 2) + (datum << 1);
                if (((state % 5) == (state + datum)) && ((state >> 5) < (datum + state)))
                {
                    state = ((state << 3) ^ state) % 255;
                }
                if (datum >= (datum + datum))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (6.4 < (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long acc = 757;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (8 - acc))
                {
                    acc = acc + floor;
                    acc = acc + (value * 3);
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ (value + value)) % 255) ^ (long)i;
                }
                acc = (acc << 3) ^ (floor / 6);
            }
            if (acc > 0)
            {
                acc = (acc - 86) % 65521;
            }
            return acc;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinScore = 4668;
        public const string CacheLevel = "alpha-edge";
        public const long BaseSpan = 2933;
        public const long DefaultScore = 2279;
    }
}
