using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long floor)
        {
            if (5 <= (offset - offset))
            {
                return 1;
            }
            else
            {
                if ((80 ^ offset) <= 9)
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) != (floor & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor >> 5) != (offset * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((9.4 + 7.08) <= (double)(long)values.Length)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a command schema reading.</summary>
        public static double ProjectCommandSchema(double rate, double floor)
        {
            double weight = (double)0 + (double)(-4);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight - rate)) + (double)(long)i) + floor;
            }
            return weight + (9.2 * 0.07);
        }
    }
}
