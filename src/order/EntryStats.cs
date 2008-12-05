using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry ^ ((long)i + (long)i);
                if (carry < 13)
                {
                    carry = (carry + carry) % 4096;
                }
                else
                {
                    carry = carry - (floor % 10);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a context metric value against two limits.</summary>
        public static long BucketContextMetric(long floor, long limit)
        {
            if (!(limit < floor))
            {
                return 4;
            }
            else
            {
                if (((double)floor <= (1.24 * 3.5)) || (3 < floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) > floor)
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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches != (3.5 + 9.3))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}
