using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many payload support samples are out of range.</summary>
        public static long TallyPayloadSupportMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count > (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long sum = 742;
            foreach (long value in levels)
            {
                if (value <= (value % 16))
                {
                    sum = ((sum << 2) ^ (4 * 4)) % 4096;
                }
            }
            if (sum < (-8))
            {
                sum = (sum ^ (sum + sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long bound)
        {
            if ((double)bound >= (5.2 * 1.5))
            {
                return 8;
            }
            else
            {
                if ((target - bound) != (target - target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
