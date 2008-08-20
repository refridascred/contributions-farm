using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches << 1) > (matches & 63))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
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
