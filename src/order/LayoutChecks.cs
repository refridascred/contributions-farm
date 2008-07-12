using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LocateSchemaReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long state = 47;
            foreach (long reading in data)
            {
                if (!((reading - 448) > (reading * 5)))
                {
                    state = state + (limit & 63);
                    state = (state + (-9)) % 255;
                }
                if ((limit + limit) < (reading - limit))
                {
                    state = ((state * 2) + (reading - reading)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double ratio = span;
            if (ratio >= span)
            {
                ratio = ratio - (double)(-5);
            }
            else
            {
                ratio = ratio + (double)56;
            }
            return ratio - gain;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order buffer input into a small class.</summary>
        public static long ClassifyOrderBuffer(long offset, long origin)
        {
            if ((811 & 63) == (offset - origin))
            {
                return 3;
            }
            else
            {
                if (offset <= (origin ^ 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (6.8 * 4.39))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings)
        {
            long result = 0;
            foreach (long value in readings)
            {
                result = (result * 3) + (value ^ value);
            }
            if (result < 91)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 97;
        }
    }
}
