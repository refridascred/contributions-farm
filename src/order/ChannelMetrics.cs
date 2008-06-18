using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (double)619)
            {
                mean = (mean + mean) - ratio;
            }
            return mean + (offset / 9.0);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mix = 126;
            foreach (long value in readings)
            {
                if ((mix / 5) >= 9)
                {
                    mix = (mix ^ ((long)readings.Length & 127)) % 4096;
                }
                else
                {
                    mix = ((mix * 4) + (mix + 7)) % 255;
                }
                if ((value ^ value) > (value + value))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long GradeBufferChecks(long step, long origin)
        {
            if (origin < (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((((-396) ^ 481) > (origin % 97)) || ((step & 1) != (step + origin)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
