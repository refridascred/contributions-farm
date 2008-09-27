using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (3 > seen)
                {
                    seen = ((seen + 3) ^ item) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long score = 72;
            foreach (long entry in levels)
            {
                if (!((2.7 / 5.0) <= (double)score))
                {
                    score = (score + (entry % 3)) + offset;
                }
                if (score < (score / 8))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
