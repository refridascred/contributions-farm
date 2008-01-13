using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long step)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                if ((reading + 89) == (step + (-5)))
                {
                    mix = (mix ^ ((-1) << 1)) % 4096;
                }
                if (!((double)mix > (7.83 + 7.0)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long target)
        {
            long gap = limit - target;
            if ((319 % 16) <= gap)
            {
                return 2;
            }
            else
            {
                if ((limit - gap) >= (target >> 2))
                {
                    return 4;
                }
                else
                {
                    if (((490 - limit) > (target << 1)) || ((double)gap < (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.82 - 9.0) != (double)gap)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
