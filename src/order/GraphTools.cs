using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Paused,
            Active,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (mix * 2)) % 1000;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 2) ^ ((long)i / 8)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= 9)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = (double)(8 >> 3);
            if (rate2 > (bias + bias))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + 4.1);
        }
    }
}
