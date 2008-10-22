using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 641;
            foreach (long datum in samples)
            {
                if ((double)mix != (double)28)
                {
                    mix = mix - 979;
                    mix = (mix << 3) ^ (datum + mix);
                }
                if ((2 * 2) == (mix + datum))
                {
                    mix = (mix * 3) + (mix * 2);
                }
            }
            if (mix > 678)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long ScoreGithubfarmCounter(long[] items, long limit)
        {
            long state = 17;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state - (value + (long)i)) % 4096;
                }
                state = state + (limit + state);
            }
            return state;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Done,
            Active,
            Closed,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = (double)(0 << 1);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - offset;
            }
            return scale + gain;
        }
    }
}
