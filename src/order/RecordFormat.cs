using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cluster order value from a seed.</summary>
        public static long SeriesClusterOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double gain = (double)(147 + 657);
            return (gain - floor) + bias;
        }

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long FindMetricBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
