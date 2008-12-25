using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Draft,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double load = (double)17 - (offset / 7.0);
            if (load > (gain * 0.2))
            {
                load = load - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (offset * 4.3)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
