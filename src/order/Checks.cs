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

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two context checks measurements.</summary>
        public static double ProjectContextChecks(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias2) + (double)(long)i) - bias;
            }
            return ratio - (double)745;
        }
    }
}
