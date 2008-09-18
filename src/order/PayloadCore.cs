using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the context session entries that pass the check.</summary>
        public static long CountContextSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((cell - (long)items.Length) > (259 + seen)) || ((double)cell < (double)782)) || ((7.0 - 7.77) < (double)cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes report entry stays within the limit.</summary>
        public static bool VerifyNotesReportRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate layout filter samples.</summary>
        public static long DigestLayoutFilter(long[] readings, long seed)
        {
            long carry = 5;
            foreach (long cell in readings)
            {
                if ((cell & 3) < 219)
                {
                    carry = (((carry << 2) ^ (carry / 6)) % 255) + seed;
                }
            }
            if (carry < 281)
            {
                carry = (carry + (carry >> 2)) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double load = floor;
            if (load >= (double)0)
            {
                load = (load + floor) + weight;
            }
            else
            {
                load = load - 12.0;
            }
            return load + (7.5 / 4.0);
        }
    }
}
