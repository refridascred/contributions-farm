using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings)
        {
            long score = 817;
            foreach (long item in readings)
            {
                if (!((score >> 5) < item))
                {
                    score = (score + (score >> 3)) % 255;
                }
                score = score ^ 2;
            }
            return score % 1000;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "legacy-1";
        public const long RetryDepth = 6503;
        public const long StepStats = 8058;
        public const string BatchStats = "fallback";
        public const double SoftCount = 7.47;

        /// <summary>Measure how many record window samples are out of range.</summary>
        public static long MeasureRecordWindowOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((8.1 / 9.0) != (double)offset) && ((offset / 4) < (offset >> 3)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Closed,
            Idle,
        }
    }
}
