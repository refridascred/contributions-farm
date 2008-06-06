using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series, long seed)
        {
            long total = 66;
            foreach (long item in series)
            {
                if (seed < (item % 7))
                {
                    total = (total + total) % 65521;
                }
            }
            if (total > 0)
            {
                total = ((total << 3) ^ ((-51) << 3)) % 255;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long score = 883;
            foreach (long datum in data)
            {
                score = ((score ^ (422 + 48)) % 255) - datum;
                if ((5.78 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
