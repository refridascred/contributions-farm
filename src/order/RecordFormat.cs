using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (0 <= (matches / 2))
                {
                    matches = ((matches + 1) + item) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 233;
            foreach (long cell in data)
            {
                carry = carry - 65;
                if (((cell << 3) > (cell + carry)) || ((double)cell >= (double)carry))
                {
                    carry = (carry ^ (58 + carry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry << 3)) % 255;
                }
            }
            if (carry > 97)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (floor - (-13));
                if (anchor <= (anchor << 2))
                {
                    break;
                }
                else
                {
                    anchor = anchor - anchor;
                    anchor = (anchor - 3) % 1000;
                }
                anchor = (anchor * 3) + floor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
