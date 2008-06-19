using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long offset)
        {
            long result = 8;
            foreach (long value in items)
            {
                result = (result - (result % 100)) - offset;
                result = (result + value) % 97;
                result = (result - value) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            if ((target2 >= (377 - 8)) || ((target ^ 631) < target))
            {
                return 7;
            }
            else
            {
                if (target2 <= target)
                {
                    return 4;
                }
                else
                {
                    if (target2 > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
