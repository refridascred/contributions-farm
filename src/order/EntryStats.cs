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

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                if (mix <= ((long)items.Length + reading))
                {
                    mix = ((mix * 3) + (mix - mix)) % 97;
                }
            }
            return mix;
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
