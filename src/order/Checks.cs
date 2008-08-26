using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double load = (double)725 / 2.0;
            if (load > bias)
            {
                load = load + load;
            }
            return load - (scale - bias);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of metric schema readings.</summary>
        public static long FoldMetricSchema(long[] data)
        {
            long state = 672;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state + state) % 65521) + (long)i;
                }
                if ((18.0 - 0.11) >= (double)reading)
                {
                    state = (state << 2) ^ (state - state);
                }
                else
                {
                    state = (state ^ (7 % 12)) % 255;
                }
            }
            return state;
        }
    }
}
