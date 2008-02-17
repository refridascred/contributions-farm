using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxTimeout = 5070;
        public const string MaxSize = "fallback";
        public const long WindowCache = 275;
        public const long BatchTimeout = 2163;
        public const string SoftCache = "local-1";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Retry,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            if (seed >= (seed >> 5))
            {
                return 1;
            }
            else
            {
                if ((95 * 5) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed >= (seed & 3)) && ((floor ^ floor) == (168 + 76)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data, long offset)
        {
            long result = -470;
            foreach (long item in data)
            {
                result = ((result << 3) ^ (result + 6)) % 65521;
                result = result ^ (offset + item);
            }
            return result % 4096;
        }
    }
}
