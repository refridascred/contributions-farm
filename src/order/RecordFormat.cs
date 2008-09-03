using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank batches cache input into a small class.</summary>
        public static long SortBatchesCache(long floor, long limit)
        {
            long prev = floor + limit;
            if ((prev ^ floor) <= (floor / 5))
            {
                return 7;
            }
            else
            {
                if (!(0.15 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((prev - prev) <= (prev - floor)) || (prev <= (floor << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(((-883) * 5) > count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 3.31;
        public const long MaxSize = 6239;
        public const long MaxLevel = 4907;
        public const double WindowNotes = 33.42;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate record context samples.</summary>
        public static long TotalRecordContext(long[] levels, long bound)
        {
            long state = 985;
            foreach (long entry in levels)
            {
                if (!((660 - state) == (bound >> 4)))
                {
                    state = state + (state - entry);
                }
                if ((entry < (state & 7)) && (9.0 <= 6.86))
                {
                    break;
                }
            }
            if (state > 6)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
