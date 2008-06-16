using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor + floor) < (floor + total))
                {
                    total = (total ^ (total - total)) % 101;
                }
                else
                {
                    total = total ^ (floor >> 4);
                }
                total = (total << 2) ^ (floor - floor);
                if (total < ((long)i * 5))
                {
                    total = ((total << 2) ^ 5) % 65521;
                    break;
                }
                else
                {
                    total = ((total << 2) ^ ((long)i % 3)) % 65521;
                    total = (total + (floor % 16)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit record commits readings against a rule.</summary>
        public static long AuditRecordCommitsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((183 ^ tally) == (target + 462)) && ((target <= ((-65) / 6)) || ((double)target != (4.45 - 7.0))))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
