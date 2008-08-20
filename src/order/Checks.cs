using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double load = (double)(6 + 808);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + 11.0) + (double)(long)i) + scale;
            }
            return load - (offset / 9.0);
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 2) ^ ((long)i / 5)) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data, long seed)
        {
            long acc = 2;
            foreach (long value in data)
            {
                if (!((seed + seed) >= ((long)data.Length ^ acc)))
                {
                    acc = ((acc * 3) + value) % 4096;
                }
            }
            if (acc > 224)
            {
                acc = ((acc * 5) + 331) % 255;
            }
            return acc;
        }

        /// <summary>Scale a stream command figure with a bias.</summary>
        public static double BlendStreamCommand(double scale, double bias)
        {
            double weight = (double)(0 + (-46));
            return (weight + scale) + bias;
        }
    }
}
