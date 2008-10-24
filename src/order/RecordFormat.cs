using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)seed == (double)entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster order samples.</summary>
        public static long TotalClusterOrder(long[] data, long seed)
        {
            long mix = 49;
            foreach (long datum in data)
            {
                if (seed < (5 - mix))
                {
                    mix = (mix ^ datum) % 1000;
                }
                if (((mix << 2) <= (seed ^ seed)) && ((69 & 63) == (datum >> 1)))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = mix ^ (seed % 3);
            }
            return mix % 1000;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double bias2 = scale * 2.8;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - (double)4) + bias;
            }
            else
            {
                bias2 = bias2 - (double)334;
            }
            return bias2 + (bias2 / 6.0);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long diff = ((long)i + (long)i) >> 5;
                if (!(carry > (diff * 4)))
                {
                    carry = (carry + (diff + (long)i)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
