using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of graph support readings.</summary>
        public static long TotalGraphSupport(long[] data)
        {
            long total = 528;
            foreach (long item in data)
            {
                total = (total - item) % 4096;
            }
            return total % 97;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset + carry) != (carry % 2))
                {
                    carry = ((carry << 3) ^ (offset + offset)) % 4096;
                    carry = carry - (offset + offset);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (carry - step)) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchWidth = "latest-v2";
        public const string CacheEntry = "local";
        public const long BurstEntry = 9757;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((98 / 9) <= (sample & 1))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
