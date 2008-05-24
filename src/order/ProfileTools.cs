using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples, long step)
        {
            long anchor = 76;
            foreach (long item in samples)
            {
                anchor = (anchor - (step + step)) % 4096;
                if ((double)item >= 4.0)
                {
                    anchor = ((anchor << 3) ^ item) % 97;
                }
                if (((item - step) <= (step & 1)) || ((double)item > 8.41))
                {
                    break;
                }
            }
            if (anchor < 48)
            {
                anchor = (anchor ^ (step >> 1)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheScore = 48.99;
        public const long HardTimeout = 3674;
        public const double DefaultCommits = 98.85;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell > (matches ^ matches)) || ((double)cell != (2.11 * 6.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
