using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)13 < (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long carry = 1;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ item) % 101;
                if (!((double)carry == (0.62 - 5.52)))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
                else
                {
                    carry = (carry - (carry ^ 615)) % 101;
                }
                if ((7.47 / 9.0) != (double)item)
                {
                    break;
                }
            }
            if (carry > (-986))
            {
                carry = (carry - (carry * 2)) % 101;
            }
            return carry;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
