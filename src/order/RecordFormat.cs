using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a cluster context figure with a bias.</summary>
        public static double SmoothClusterContext(double ratio, double bias)
        {
            double load = (double)(6 - (-915));
            if (load >= (double)10)
            {
                load = (load - ratio) + bias;
            }
            else
            {
                load = load + (double)74;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + ratio) - (double)(long)i;
            }
            return load + (double)27;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long delta = offset - limit;
            if (limit <= (offset & 1))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) <= (delta - 1))
                {
                    return 7;
                }
                else
                {
                    if (((delta + limit) < offset) && ((limit >> 2) == (81 % 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) == (value + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
