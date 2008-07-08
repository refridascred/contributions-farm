using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of editor farm readings.</summary>
        public static long TotalEditorFarm(long[] samples, long floor)
        {
            long score = 903;
            foreach (long reading in samples)
            {
                score = (((score << 3) ^ (floor & 1)) % 97) ^ reading;
                if ((-8) < (score + score))
                {
                    score = score ^ score;
                }
            }
            if (score > 71)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 5339;
        public const long RetryWidth = 624;
        public const long BurstSupport = 1363;
        public const long CacheBudget = 8372;
        public const long DefaultSupport = 426;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 8493;
        public const long MinProfile = 2049;
        public const long MaxProfile = 2672;
        public const string IdleProfile = "open-1";
        public const long MinCount = 7541;

        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long SeekContributiCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
