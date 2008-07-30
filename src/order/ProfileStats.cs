using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 9027;
        public const double BatchFormat = 57.1;
        public const long WindowFormat = 7716;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 276;
            foreach (long item in data)
            {
                acc = (acc + acc) % 255;
                if (item > (item >> 3))
                {
                    acc = (acc << 2) ^ (acc % 2);
                }
                acc = acc ^ (acc << 3);
            }
            if (acc > (-12))
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc % 8)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
