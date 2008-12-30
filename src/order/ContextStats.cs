using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long step)
        {
            long sum = 893;
            foreach (long datum in values)
            {
                if ((datum + 6) == ((-28) * 2))
                {
                    sum = ((sum * 2) + step) % 4096;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                if (((490 + datum) <= 5) && (sum > (step + step)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Dropped,
            New,
            Queued,
            Retry,
        }
    }
}
