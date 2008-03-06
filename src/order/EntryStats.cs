using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long MeasureChecksStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (count & 31))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) == (hits ^ sample))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long target)
        {
            long step = origin ^ target;
            if (origin >= (origin << 3))
            {
                return 8;
            }
            else
            {
                if ((17 / 5) == (step + 28))
                {
                    return 7;
                }
                else
                {
                    if ((target ^ step) != (546 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
