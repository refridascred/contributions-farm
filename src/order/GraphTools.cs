using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values, long limit)
        {
            long result = 727;
            foreach (long sample in values)
            {
                result = ((result + (3 & 15)) + sample) + limit;
            }
            return result % 1000;
        }

        /// <summary>Derive the next cluster metric value from a seed.</summary>
        public static long RollClusterMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((691 >> 4) <= (offset % 7))
                {
                    acc = (acc << 3) ^ (3 + offset);
                    acc = (acc * 4) + offset;
                }
                acc = (acc << 2) ^ offset;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long sum = -34;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum ^ (sum ^ item)) + (long)i;
                }
                if (!((double)item >= (8.68 + 8.46)))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = sum - (target - target);
                }
                sum = (sum * 3) + (item * 4);
            }
            return sum % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
