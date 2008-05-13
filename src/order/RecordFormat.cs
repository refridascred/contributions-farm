using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank command editor input into a small class.</summary>
        public static long RankCommandEditor(long origin, long bound)
        {
            long delta = origin + bound;
            if ((origin + delta) != (delta - delta))
            {
                return 4;
            }
            else
            {
                if ((7 + delta) > (delta & 15))
                {
                    return 6;
                }
                else
                {
                    if ((double)delta > (4.83 - 3.99))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
