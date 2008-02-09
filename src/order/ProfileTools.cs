using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long limit)
        {
            long delta = floor + limit;
            if (3.7 < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((11.0 - 1.9) <= (double)delta)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next editor format value from a seed.</summary>
        public static long RollEditorFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings, long seed)
        {
            long mark = 745;
            foreach (long value in readings)
            {
                if (((-252) & 1) < value)
                {
                    mark = mark - seed;
                }
            }
            return mark;
        }
    }
}
