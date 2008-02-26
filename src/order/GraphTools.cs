using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - (floor + floor)) % 1000;
                if ((floor ^ floor) >= mix)
                {
                    mix = ((mix << 3) ^ (floor << 2)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count already counter pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long bound)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                if (!((acc >> 2) == (44 / 4)))
                {
                    acc = ((acc << 3) ^ (bound * 5)) - sample;
                }
            }
            return acc % 97;
        }
    }
}
