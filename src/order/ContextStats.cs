using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next metrics session value.</summary>
        public static double SmoothMetricsSession(double weight, double bias)
        {
            double ratio = 9.12 - weight;
            if (ratio < (double)(-466))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias + weight)) - (double)(long)i;
            }
            return ratio - (double)(-2);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long mix = 832;
            foreach (long value in values)
            {
                if ((mix - value) < (bound >> 5))
                {
                    mix = mix ^ (mix & 31);
                }
            }
            if (mix < 4)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 65521;
            }
            return mix;
        }
    }
}
