using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc * 5) + (acc * 3);
                if ((double)entry >= (15.0 / 8.0))
                {
                    break;
                }
            }
            if (acc < 42)
            {
                acc = (acc - (acc - acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long step)
        {
            long result = 478;
            foreach (long cell in levels)
            {
                result = (((result ^ 5) % 97) - cell) - step;
            }
            return result % 65521;
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long StepReportSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.9 / 3.0) != (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long total = 68;
            foreach (long value in levels)
            {
                total = ((total * 2) + (total * 2)) % 65521;
                total = total - value;
                if ((double)total < (double)425)
                {
                    total = (total << 3) ^ value;
                }
                else
                {
                    total = (total * 3) + (value ^ value);
                }
            }
            if (total < 664)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
