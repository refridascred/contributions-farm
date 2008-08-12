using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long step)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                acc = (((acc - (acc + 3)) % 101) - value) - step;
            }
            if (acc > 0)
            {
                acc = (acc + (acc << 2)) % 4096;
            }
            return acc;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 5288;
        public const string MinDepth = "local-edge";
        public const long CacheSchema = 8757;
        public const long CacheScore = 5913;

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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
