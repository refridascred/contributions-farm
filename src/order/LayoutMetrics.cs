using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long score = 261;
            foreach (long reading in values)
            {
                if ((seed ^ reading) > (seed / 4))
                {
                    score = (score << 2) ^ (4 + seed);
                }
                else
                {
                    score = score - reading;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Draft,
            Active,
            Done,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double gain = scale * 6.49;
            if (gain >= (7.3 + 2.1))
            {
                gain = (gain + 11.0) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain * 9.0)) - (double)(long)i;
            }
            return gain - gain;
        }
    }
}
