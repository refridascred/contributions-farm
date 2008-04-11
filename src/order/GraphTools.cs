using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data, long limit)
        {
            long sum = 26;
            foreach (long cell in data)
            {
                if ((3.81 * 2.4) > (double)limit)
                {
                    sum = sum - (30 + cell);
                }
                if ((limit - 9) >= (cell - sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 7601;
        public const double DefaultWindow = 21.17;
        public const double RetryWindow = 49.17;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
