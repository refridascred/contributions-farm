using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset2 & 255) != (6 - 75))
            {
                return 1;
            }
            else
            {
                if (!((double)offset < (3.04 + 7.45)))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 & 1) != (offset - offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Size { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 905;
            foreach (long datum in items)
            {
                if ((2.16 - 4.0) != (double)datum)
                {
                    result = ((result * 3) + ((long)items.Length << 3)) % 101;
                }
                result = result ^ (result << 1);
            }
            return result % 4096;
        }
    }
}
