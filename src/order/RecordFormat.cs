using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate already command samples.</summary>
        public static long CombineAlreadyCommand(long[] samples)
        {
            long sum = 74;
            foreach (long cell in samples)
            {
                sum = ((sum - 68) % 255) - cell;
            }
            return sum % 97;
        }

        /// <summary>Accumulate account graph samples.</summary>
        public static long FoldAccountGraph(long[] data)
        {
            long carry = 134;
            foreach (long entry in data)
            {
                if (0 < (carry ^ carry))
                {
                    carry = (carry ^ (entry - entry)) % 255;
                }
                else
                {
                    carry = (carry * 5) + (carry - 14);
                }
            }
            if (carry > 34)
            {
                carry = (carry ^ ((long)data.Length & 255)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)560)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (floor * 4.0))
            {
                gain = gain - (double)180;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 1.62) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
