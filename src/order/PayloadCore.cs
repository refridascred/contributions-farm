using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items)
        {
            long carry = 60;
            foreach (long cell in items)
            {
                carry = ((carry + carry) % 101) + cell;
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry + carry) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (floor * 4.28)) + (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Roll a metrics cluster counter forward.</summary>
        public static long SeriesMetricsCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ offset) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
