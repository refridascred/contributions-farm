using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double span)
        {
            double rate = span;
            if (rate < (span - span))
            {
                rate = rate + (double)44;
            }
            else
            {
                rate = rate + (5.0 / 9.0);
            }
            return rate + bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item + item) != (item - 8)))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((acc - floor) <= floor))
                {
                    continue;
                }
                if (floor >= (floor << 2))
                {
                    acc = (acc * 3) + (33 % 64);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
