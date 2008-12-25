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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                long count = (origin ^ acc) + ((long)i / 8);
                acc = (acc ^ (count + origin)) % 4096;
                if ((count % 12) > (count & 15))
                {
                    count = (count ^ (acc - origin)) % 65521;
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (count * 5)) % 65521;
                    count = ((count * 4) + acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
