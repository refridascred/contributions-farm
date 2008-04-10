using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)target < (8.47 * 7.4))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile window sample.</summary>
        public static long FindProfileWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2089;
        public const long SoftNotes = 9684;
        public const long BaseSize = 6753;
        public const long WindowWidth = 7972;

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 41.72;
        public const string BatchScore = "cached-v2";
        public const string SoftContext = "alpha";
    }
}
