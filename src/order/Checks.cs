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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
