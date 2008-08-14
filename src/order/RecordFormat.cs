using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "staging-v2";
        public const string BaseChannel = "staging-edge";
        public const long MaxFactor = 6869;
        public const long WindowChannel = 6780;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Failed,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            long slot = floor - limit;
            if (!((double)limit > (16.0 + 6.0)))
            {
                return 8;
            }
            else
            {
                if (((0 - floor) >= (floor & 63)) || ((100 - floor) > (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit + limit) < (slot ^ floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > slot) && ((limit + limit) > (limit << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
