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

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((13.0 + 1.2) >= (double)score)
                {
                    score = ((score << 2) ^ (453 - 4)) % 65521;
                }
                long matches = 425;
                if ((score - step) <= matches)
                {
                    matches = (matches ^ step) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
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
