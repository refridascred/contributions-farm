using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of editor commits entries.</summary>
        public static long WeighEditorCommits(long[] values, long bound)
        {
            long anchor = 4;
            foreach (long value in values)
            {
                if (((value % 3) <= (value - bound)) && ((bound ^ value) <= (anchor + bound)))
                {
                    anchor = (anchor + (bound % 2)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Find the first editor metric entry that matches the target.</summary>
        public static long LocateEditorMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (572 >= matches)
                {
                    matches = ((matches + 3) ^ item) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double weight = scale / 5.0;
            if (weight > weight)
            {
                weight = weight + (weight / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (9.8 + weight)) + (double)(long)i;
            }
            return weight - (bias - weight);
        }
    }
}
