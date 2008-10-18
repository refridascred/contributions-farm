using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark << 2) ^ (step + 330)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark + (step + mark)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((limit + 97) >= (-26)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double bias, double bias2)
        {
            double bias3 = bias2 * 1.92;
            if (bias3 < (bias / 2.0))
            {
                bias3 = bias3 + bias3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias + 0.2)) + (double)(long)i;
            }
            return bias3 + bias;
        }
    }
}
