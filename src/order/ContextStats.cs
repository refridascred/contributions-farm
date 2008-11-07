using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double gain = (offset - offset) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (offset / 7.0)) - (double)(long)i) - bias;
            }
            return gain - offset;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 734;
            foreach (long value in data)
            {
                if (!(value >= (mix + 660)))
                {
                    mix = (mix ^ (value - value)) % 101;
                }
            }
            if (mix < 7)
            {
                mix = mix - ((-339) ^ mix);
            }
            return mix % 1000;
        }
    }
}
