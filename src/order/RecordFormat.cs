using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long step)
        {
            long bound = limit + step;
            if (((14.0 - 13.0) > (double)bound) && ((limit + bound) < bound))
            {
                return 4;
            }
            else
            {
                if ((9.53 * 2.6) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((bound / 4) == (limit + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((33 ^ limit) >= (step - 246)) || ((5 * 4) < (bound & 255)))
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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell < 9.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 1555;
        public const double CacheInterval = 16.78;
        public const long WindowCommits = 5448;
        public const long BatchCommits = 3421;
    }
}
