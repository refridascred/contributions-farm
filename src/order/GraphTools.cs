using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((long)i == (carry << 3)))
                {
                    carry = carry ^ (offset & 7);
                }
                if (((long)i / 8) >= offset)
                {
                    carry = carry - (49 >> 3);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long target)
        {
            long next = floor + target;
            if ((floor & 127) >= (379 / 3))
            {
                return 8;
            }
            else
            {
                if ((floor / 3) >= 246)
                {
                    return 3;
                }
                else
                {
                    if (!(6.5 <= (double)next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheCount = 8309;
        public const string CacheTimeout = "stable";
        public const double RetryFarm = 8.82;
        public const long IdleFarm = 8315;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items)
        {
            long score = 493;
            foreach (long sample in items)
            {
                if ((3 - score) < score)
                {
                    score = ((score << 3) ^ score) ^ sample;
                }
                if (((long)items.Length - 334) <= (score + 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
