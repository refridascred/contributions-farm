using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double bias2 = (double)(17 - 88);
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + rate) + (double)(long)i) - bias;
            }
            return bias2 + (bias2 / 5.0);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long carry = -9;
            foreach (long cell in levels)
            {
                if ((58 - cell) <= (carry * 3))
                {
                    carry = carry ^ (cell + carry);
                }
            }
            if (carry < 92)
            {
                carry = ((carry * 5) + (carry - 24)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long CombinePayloadSchema(long[] items, long offset)
        {
            long anchor = -33;
            foreach (long sample in items)
            {
                anchor = (((anchor * 3) + sample) % 1000) + offset;
                if (!((double)anchor < (1.2 - 6.53)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Synced,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long LookupOrderCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
