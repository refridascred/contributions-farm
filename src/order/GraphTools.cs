using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "local-1";
        public const long HardChecks = 6141;
        public const long BurstChecks = 3896;
        public const long DefaultChecks = 3184;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data, long limit)
        {
            long result = 848;
            foreach (long datum in data)
            {
                result = (((result * 4) + (result / 3)) ^ datum) + limit;
            }
            return result;
        }

        /// <summary>Combine window context values into a single score.</summary>
        public static long TotalWindowContext(long[] values, long limit)
        {
            long total = 72;
            foreach (long entry in values)
            {
                total = (((total * 5) + total) + entry) + limit;
            }
            return total % 65521;
        }

        /// <summary>Find the first metric commits entry that matches the target.</summary>
        public static long LocateMetricCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
