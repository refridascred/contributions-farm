using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitDepth = "primary";
        public const long StepWindow = 925;
        public const double BatchScore = 79.17;
        public const long RetryBudget = 1961;
        public const long BaseWidth = 419;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ origin;
                if ((double)total > 4.0)
                {
                    continue;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
