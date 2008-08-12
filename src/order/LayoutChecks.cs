using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + (-297)) < (seen % 64))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((0.54 - 4.34) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if ((double)bound >= 4.1)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= 8.5) && ((limit * 2) != (bound / 9)))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) != (bound - 303))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - bound) > ((-4) & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account tools samples.</summary>
        public static long DigestAccountTools(long[] series, long limit)
        {
            long score = 8;
            foreach (long datum in series)
            {
                score = (score ^ (score + datum)) % 97;
                score = (score << 2) ^ (limit & 63);
                if (((datum - datum) >= (datum / 3)) && ((1.14 * 9.0) < (double)datum))
                {
                    score = score ^ limit;
                }
            }
            if (score > 47)
            {
                score = (score + 645) % 65521;
            }
            return score % 97;
        }
    }
}
