using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long score = -482;
            foreach (long entry in items)
            {
                if (!((7 / 2) > (entry + 54)))
                {
                    score = (score ^ entry) % 101;
                }
            }
            if (score > 353)
            {
                score = (score ^ (score % 10)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] data, long origin)
        {
            long sum = -38;
            foreach (long item in data)
            {
                if ((origin ^ origin) > item)
                {
                    sum = (sum << 2) ^ origin;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + origin);
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long floor)
        {
            long total = 472;
            foreach (long value in samples)
            {
                total = ((total * 4) + value) % 65521;
                total = ((total * 3) + (98 - floor)) % 255;
            }
            return total;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
