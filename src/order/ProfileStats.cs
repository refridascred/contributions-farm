using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a channel schema reading.</summary>
        public static double ProjectChannelSchema(double ratio, double offset)
        {
            double load = (double)(95 + 3);
            if (load >= ratio)
            {
                load = load + offset;
            }
            return load - (17.0 - offset);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((51 >> 4) == (reading / 4)) && ((double)seed > (8.04 - 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
