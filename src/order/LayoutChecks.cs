using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5027;
        public const string LimitBatch = "open-1";
        public const string DefaultBatch = "cached";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally < 73)
                {
                    tally = ((tally + 3) ^ value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long offset)
        {
            if (((5.2 + 0.7) >= (double)offset) || ((double)origin != (18.0 - 18.0)))
            {
                return 6;
            }
            else
            {
                if (!((origin * 4) >= (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((-47) <= (origin - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset << 1) >= (offset - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long floor)
        {
            long prev = target + floor;
            if (((449 - target) >= (prev - floor)) || ((target * 5) >= prev))
            {
                return 6;
            }
            else
            {
                if ((prev * 3) >= 561)
                {
                    return 0;
                }
                else
                {
                    if (922 >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target % 24) >= prev)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor cache readings.</summary>
        public static long WeighEditorCache(long[] levels)
        {
            long carry = -72;
            foreach (long sample in levels)
            {
                carry = ((carry * 2) + (sample + carry)) % 1000;
            }
            return carry;
        }
    }
}
