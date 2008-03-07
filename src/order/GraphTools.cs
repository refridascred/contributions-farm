using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if (((step >> 2) < (sample % 5)) && (step > (sample * 4)))
                {
                    anchor = ((anchor << 2) ^ sample) % 65521;
                    anchor = ((anchor * 2) + (sample + sample)) % 65521;
                }
                anchor = ((anchor * 2) + (-244)) % 255;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= offset)
            {
                ratio = ratio + (offset + 0.5);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (offset - ratio)) + (double)(long)i;
            }
            return ratio - (double)55;
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long TotalQueueCache(long[] series, long floor)
        {
            long acc = -51;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ floor) % 255) - entry;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of cluster batch readings.</summary>
        public static long MatchClusterBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
