using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long result = 352;
            foreach (long item in items)
            {
                if ((item + (-79)) <= (item + result))
                {
                    result = ((result << 2) ^ (result + 762)) % 1000;
                }
            }
            if (result > 77)
            {
                result = ((result << 3) ^ (result & 31)) % 1000;
            }
            return result;
        }

        /// <summary>Validate stream metric readings against a bound.</summary>
        public static bool GuardStreamMetricBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the farm order series from a seed.</summary>
        public static long RollFarmOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = carry + (carry >> 3);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many record entry samples are out of range.</summary>
        public static long AuditRecordEntryHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) >= 694)
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
