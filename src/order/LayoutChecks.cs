using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next format metrics value from a seed.</summary>
        public static long IterateFormatMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)target > (4.76 * 10.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a farm record reading by value.</summary>
        public static long LookupFarmRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                if (5.76 >= (double)carry)
                {
                    carry = ((carry * 5) + reading) % 4096;
                }
                else
                {
                    carry = (carry << 2) ^ (reading + reading);
                }
            }
            return carry;
        }
    }
}
