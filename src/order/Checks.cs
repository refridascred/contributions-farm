using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > offset)
            {
                ratio = ratio - (scale + ratio);
            }
            else
            {
                ratio = ratio + (offset * 0.8);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 7.08) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double load = (double)(31 / 6);
            if (load >= floor)
            {
                load = load + (load + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (load + gain)) + (double)(long)i;
            }
            return load - (load - gain);
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) == ((long)items.Length / 3))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
