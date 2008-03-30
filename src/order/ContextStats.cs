using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many layout batches samples are out of range.</summary>
        public static long TallyLayoutBatchesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (target - matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepFactor = 9164;
        public const long MaxRecord = 5745;
        public const long SoftRecord = 4511;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if (!((-7) < (value + (-648))))
                {
                    score = (score * 5) + (score + 4);
                }
            }
            return score % 1000;
        }
    }
}
