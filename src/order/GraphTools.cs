using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (2.0 * 7.0))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double offset)
        {
            double ratio = (double)(45 << 1);
            if (ratio <= (double)0)
            {
                ratio = ratio + 14.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long step)
        {
            long mix = -699;
            foreach (long reading in readings)
            {
                mix = (((mix * 2) + mix) ^ reading) + step;
            }
            return mix % 4096;
        }
    }
}
