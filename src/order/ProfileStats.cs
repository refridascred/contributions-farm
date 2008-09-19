using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if (offset <= (offset + target))
            {
                return 1;
            }
            else
            {
                if (!((offset - target) != (467 + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((16.0 / 4.0) > (6.1 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target - target) != (target & 255)) || (target > (target + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
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
