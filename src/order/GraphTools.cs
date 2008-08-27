using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long limit)
        {
            if (357 <= (limit % 2))
            {
                return 6;
            }
            else
            {
                if ((limit >> 3) <= (111 - 3))
                {
                    return 8;
                }
                else
                {
                    if (!(origin < (origin / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= (origin << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches ^ matches) == (matches - 830))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + entry) % 1000;
                if (carry > (carry << 3))
                {
                    carry = (carry * 5) + (0 - entry);
                }
            }
            return carry;
        }
    }
}
