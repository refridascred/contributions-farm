using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)bound <= (2.1 / 2.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((8.0 - 7.0) <= (double)carry)
                {
                    carry = (carry + (step - 5)) % 101;
                }
                if ((step & 15) > carry)
                {
                    carry = (carry ^ ((long)i * 3)) % 101;
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double ratio = (gain / 6.0) - (double)(-568);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) - offset;
            }
            return ratio - (ratio - 12.0);
        }
    }
}
