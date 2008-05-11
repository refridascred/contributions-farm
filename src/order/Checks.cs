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

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 8424;
        public const string MaxStats = "legacy-edge";
        public const long WindowStats = 1672;
        public const string BatchStats = "open";
        public const long HardStats = 6150;

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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long offset)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                if ((carry + 51) > (offset >> 1))
                {
                    carry = ((carry - (offset & 15)) % 255) + sample;
                }
                else
                {
                    carry = carry ^ (carry & 127);
                }
            }
            return carry;
        }
    }
}
