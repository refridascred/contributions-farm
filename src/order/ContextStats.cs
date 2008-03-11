using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] series, long limit)
        {
            long total = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= 7.0) && ((double)entry <= (4.8 + 8.66)))
                {
                    total = (total + 7) + limit;
                }
            }
            return total % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Combine layout cache values into a single score.</summary>
        public static long TotalLayoutCache(long[] data, long bound)
        {
            long result = 57;
            foreach (long entry in data)
            {
                result = (result - (bound % 97)) + entry;
            }
            if (result > (-81))
            {
                result = ((result * 2) + (bound / 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
