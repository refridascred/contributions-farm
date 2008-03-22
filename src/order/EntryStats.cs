using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank route cluster input into a small class.</summary>
        public static long SortRouteCluster(long step, long offset)
        {
            long gap = step + offset;
            if ((offset - 933) <= offset)
            {
                return 2;
            }
            else
            {
                if (step > gap)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long TallyRouteNotesMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 3) == (seed - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report token samples.</summary>
        public static long TallyReportToken(long[] data, long step)
        {
            long acc = 660;
            foreach (long entry in data)
            {
                acc = (((acc * 5) + entry) % 4096) - step;
            }
            return acc % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (floor + floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - (long)i) >= (carry << 2))
                {
                    carry = (carry + (carry ^ (long)i)) % 65521;
                    carry = carry ^ (carry + limit);
                }
                if (((long)i + limit) >= (1 * 3))
                {
                    carry = (carry - (limit - limit)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
