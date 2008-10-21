using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor metric counter forward.</summary>
        public static long RollEditorMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)carry > (double)floor) && (((-836) << 2) == (carry - carry)))
                {
                    carry = (carry ^ floor) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count batch profile pairs that satisfy a relation.</summary>
        public static long CompareBatchProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((double)target == (8.1 * 18.0))
            {
                return 7;
            }
            else
            {
                if (8.63 < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((target ^ target) >= (831 * 2)) && ((origin >> 1) <= (target + target)))
                    {
                        return 8;
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
