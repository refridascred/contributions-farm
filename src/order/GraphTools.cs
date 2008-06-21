using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 2690;
        public const long BaseTimeout = 1854;
        public const double DefaultLevel = 74.09;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long mix = 102;
            foreach (long reading in data)
            {
                if ((mix - limit) >= 628)
                {
                    mix = ((mix + (mix >> 5)) % 97) - reading;
                }
                else
                {
                    mix = ((mix << 2) ^ limit) % 65521;
                }
                if (((1.4 * 10.0) > (double)(long)data.Length) && ((double)mix <= (10.0 - 9.0)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double load = (weight / 3.0) * 7.3;
            return (load + (double)801) + bias;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double floor)
        {
            double gain = (floor / 9.0) - floor;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (bias * 8.9);
        }
    }
}
