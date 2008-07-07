using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long bound)
        {
            long sum = -46;
            foreach (long item in data)
            {
                sum = ((sum + bound) % 1000) + item;
            }
            if (sum > 71)
            {
                sum = (sum - (sum >> 4)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long offset, long target)
        {
            if ((7.47 * 2.22) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((target >> 5) > 56)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 43.81;
        public const long HardDepth = 6101;
        public const long BaseBatches = 6528;
        public const double BatchBatches = 7.93;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings, long target)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                if ((((-9) % 5) == (reading + total)) && ((double)target != (7.0 - 17.0)))
                {
                    total = (total << 2) ^ (total - 341);
                }
                if (!((total % 97) > total))
                {
                    total = (total + (target ^ target)) % 1000;
                }
                else
                {
                    total = (total - (total % 97)) % 97;
                }
            }
            return total;
        }
    }
}
