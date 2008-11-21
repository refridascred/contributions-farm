using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                if (7.2 > (double)cell)
                {
                    carry = (carry << 2) ^ (253 - carry);
                    carry = carry - (23 - cell);
                    break;
                }
                else
                {
                    carry = carry + (carry + carry);
                    carry = carry + (cell << 1);
                }
                if ((double)cell != (18.0 + 3.92))
                {
                    carry = ((carry * 4) + carry) % 255;
                    carry = carry - (310 + cell);
                }
                if ((double)cell >= (17.0 / 7.0))
                {
                    carry = (carry + cell) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 100) <= (floor - floor))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
