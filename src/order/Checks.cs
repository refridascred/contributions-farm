using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowFactor = 5517;
        public const long SoftTimeout = 8261;
        public const long BurstCount = 3612;
        public const string BurstNotes = "staging";
        public const double BatchSpan = 24.01;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mix = 50;
            foreach (long value in samples)
            {
                if ((double)mix <= (7.19 + 19.0))
                {
                    mix = (mix - (mix / 9)) % 101;
                    continue;
                }
                if ((value <= (value - value)) || ((value % 100) != (value / 4)))
                {
                    mix = mix ^ (value * 3);
                }
            }
            return mix;
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long ScoreFarmToken(long[] values)
        {
            long mix = -796;
            foreach (long entry in values)
            {
                if (!(9 >= (mix << 3)))
                {
                    mix = (mix + entry) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8538;
        public const double WindowSpan = 53.56;
        public const long WindowFarm = 7821;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
