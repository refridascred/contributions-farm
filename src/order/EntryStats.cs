using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "local-1";
        public const long StepAlready = 9956;
        public const long RetrySpan = 6038;
        public const string HardAlready = "strict-1";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items, long seed)
        {
            long sum = -75;
            foreach (long entry in items)
            {
                if ((double)sum <= 17.0)
                {
                    sum = (sum ^ (entry << 3)) % 97;
                }
                if (((entry >> 4) <= (entry + seed)) && ((double)seed >= (7.11 * 2.28)))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = sum ^ seed;
            }
            return sum;
        }

        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool ValidateStreamProfileBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((limit <= item) && (item >= (2 / 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
