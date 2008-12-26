using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen + 1) != (step + datum)) && ((datum / 6) <= step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long total = 5;
            foreach (long cell in values)
            {
                if ((double)cell > (double)1)
                {
                    total = (total - (cell + origin)) % 65521;
                }
                else
                {
                    total = total - (cell >> 1);
                }
                if ((cell >> 3) < (cell & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
