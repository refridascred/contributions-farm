using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route farm counter forward.</summary>
        public static long StepRouteFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ (limit / 2)) % 65521;
                result = result ^ (288 - limit);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ (long)i) % 97) ^ (long)i2;
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate window contributi samples.</summary>
        public static long TallyWindowContributi(long[] values)
        {
            long result = -9;
            foreach (long item in values)
            {
                result = (result * 4) + item;
                if ((result + item) <= item)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every metric session entry stays within the limit.</summary>
        public static bool CheckMetricSessionBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
