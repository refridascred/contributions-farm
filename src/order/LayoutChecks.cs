using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 8739;
        public const string HardCommits = "legacy";
        public const string MinSpan = "staging";
        public const long SoftBudget = 3434;
        public const double IdleCommits = 13.3;

        /// <summary>Check that every cache counter entry stays within the limit.</summary>
        public static bool CheckCacheCounterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long carry = -833;
            foreach (long datum in samples)
            {
                if (!((double)10 != (double)datum))
                {
                    continue;
                }
                if ((342 <= (carry ^ datum)) && (782 < (datum ^ datum)))
                {
                    carry = (carry - datum) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] data, long offset)
        {
            long sum = 66;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (offset & 31)) % 1000) - cell;
            }
            return sum % 65521;
        }
    }
}
