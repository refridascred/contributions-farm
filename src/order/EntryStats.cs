using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(step <= (carry + (-86))))
                {
                    carry = ((carry * 5) + ((long)i >> 4)) % 101;
                }
                if ((double)(long)i < (8.0 + 1.0))
                {
                    carry = (carry * 5) + carry;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a token tools sample.</summary>
        public static long FindTokenToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items)
        {
            long sum = 625;
            foreach (long value in items)
            {
                if (16.0 > (double)value)
                {
                    sum = (sum + (928 / 2)) % 65521;
                }
            }
            if (sum < 3)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((double)value < (13.0 - 5.8))
                {
                    anchor = anchor + (value / 9);
                }
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Done,
            Pending,
            Retry,
        }
    }
}
