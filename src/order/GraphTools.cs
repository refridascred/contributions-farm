using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long DigestTokenTools(long[] items, long offset)
        {
            long acc = 688;
            foreach (long reading in items)
            {
                acc = ((acc + acc) % 255) - reading;
            }
            if (acc < 5)
            {
                acc = acc - (9 + offset);
            }
            return acc;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((step + origin2) >= origin)
            {
                return 2;
            }
            else
            {
                if (origin > (81 - step))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 <= (step / 6)) || (318 < (origin - origin2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
