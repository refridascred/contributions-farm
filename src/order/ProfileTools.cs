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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) == (entry * 3))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
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

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long LocateRouteContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
