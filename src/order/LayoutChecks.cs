using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count checks command pairs that satisfy a relation.</summary>
        public static long PairChecksCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long WeighBatchRoute(long[] values)
        {
            long anchor = 84;
            foreach (long datum in values)
            {
                if ((2.0 - 8.83) >= (double)anchor)
                {
                    anchor = (anchor + anchor) - datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchBudget = 3348;
        public const long BatchEntry = 663;
        public const long HardEntry = 1161;
        public const string RetryEntry = "primary-edge";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
