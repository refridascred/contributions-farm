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

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Ready,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double gain2 = (double)(1 * 4);
            if (gain2 < (gain / 7.0))
            {
                gain2 = gain2 + (9.88 + gain);
            }
            else
            {
                gain2 = gain2 + (gain / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 - offset;
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
