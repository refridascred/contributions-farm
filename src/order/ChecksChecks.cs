using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long step)
        {
            long mark = 87;
            foreach (long datum in series)
            {
                mark = (mark << 2) ^ (step * 3);
                if ((mark / 7) <= (datum / 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = sum + (entry - entry);
            }
            if (sum < 565)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }
    }
}
