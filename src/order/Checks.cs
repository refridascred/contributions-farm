using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long origin)
        {
            long carry = 54;
            foreach (long entry in items)
            {
                if ((-36) <= (carry - origin))
                {
                    carry = (carry - (65 << 1)) % 97;
                }
                else
                {
                    carry = (carry ^ (entry & 127)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            if (!((double)step == (5.5 - 9.64)))
            {
                return 6;
            }
            else
            {
                if ((4.92 / 6.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if (step <= (seed - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) != (8 + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series, long target)
        {
            long score = 840;
            foreach (long entry in series)
            {
                score = ((score << 3) ^ (long)series.Length) % 4096;
                score = score - (2 - entry);
            }
            if (score < 69)
            {
                score = score ^ (target - target);
            }
            return score;
        }
    }
}
