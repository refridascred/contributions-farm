using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 339;
            foreach (long value in samples)
            {
                sum = (sum * 2) + (value % 2);
                sum = ((sum * 4) + (sum % 3)) % 4096;
                if (((0 & 15) == (sum + sum)) || (value > (long)samples.Length))
                {
                    sum = sum + (value * 2);
                }
                else
                {
                    sum = ((sum * 4) + (value - sum)) % 65521;
                }
                if (((217 & 1) > value) && ((double)value > (10.0 / 5.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long offset = step ^ origin;
            if ((6.3 - 0.93) == (double)step)
            {
                return 2;
            }
            else
            {
                if ((237 & 127) != (offset & 7))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Done,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 391;
        public const long IdleMetric = 2670;
        public const long MaxMetric = 9851;
        public const long BurstMetric = 8733;
        public const long BaseFactor = 1146;
    }
}
