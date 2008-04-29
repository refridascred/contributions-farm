using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first batches filter entry that matches the target.</summary>
        public static long FindBatchesFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long score = 6;
            foreach (long datum in samples)
            {
                score = score - score;
                if (4.0 < (double)score)
                {
                    score = (score - datum) % 4096;
                }
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) < 320)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long delta = step - bound;
            if ((bound * 5) > bound)
            {
                return 5;
            }
            else
            {
                if ((step - delta) == (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((step - bound) >= delta)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
