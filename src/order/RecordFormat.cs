using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheScore = 1674;
        public const string WindowAlready = "latest-v2";
        public const long MinAlready = 7556;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((origin ^ reading) < (reading + 9))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long state = 91;
            foreach (long entry in items)
            {
                state = (state - (state + entry)) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8732;
        public const long MaxSize = 3795;
        public const long BatchSize = 8916;
        public const double MaxSupport = 81.89;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
