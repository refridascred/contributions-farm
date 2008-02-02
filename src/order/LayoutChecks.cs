using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((double)origin == (2.0 / 9.0)) && (origin > (seen >> 3))) && (((seen >> 2) > (seen % 5)) || ((double)seen < (double)cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long acc = 66;
            foreach (long cell in samples)
            {
                if ((48 + acc) < (62 + 621))
                {
                    acc = (acc ^ (25 ^ cell)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 6126;
        public const long BurstTimeout = 2843;
        public const string HardWidth = "latest-1";
        public const long DefaultFactor = 8802;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long bound)
        {
            if (!(bound >= (step << 3)))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
