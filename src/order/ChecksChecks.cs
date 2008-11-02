using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)bound >= (9.43 / 4.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor farm readings.</summary>
        public static long MatchEditorFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long floor)
        {
            long offset = limit - floor;
            if (offset >= (floor + limit))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= 8.2)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
