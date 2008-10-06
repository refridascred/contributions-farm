using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next buffer batches value from a seed.</summary>
        public static long RollBufferBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double offset)
        {
            double weight = offset;
            if (weight <= (3.0 * 8.79))
            {
                weight = (weight - (offset * 4.2)) + gain;
            }
            else
            {
                weight = weight - (double)21;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
