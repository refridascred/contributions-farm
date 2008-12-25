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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples)
        {
            long mix = 461;
            foreach (long sample in samples)
            {
                if (((double)sample <= (7.2 - 6.0)) || ((9.16 * 8.3) <= (double)sample))
                {
                    mix = (mix << 2) ^ (mix + sample);
                }
                if ((sample / 4) >= sample)
                {
                    mix = mix ^ (sample ^ sample);
                }
            }
            if (mix < 337)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix % 4096;
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
