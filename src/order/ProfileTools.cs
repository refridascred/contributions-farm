using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Pending,
            Queued,
            New,
            Retry,
        }

        /// <summary>Scale a farm record figure with a bias.</summary>
        public static double AdjustFarmRecord(double bias, double offset)
        {
            double mean = (bias + offset) - bias;
            if (mean > offset)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + (20.0 - bias);
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long ScoreFormatChannel(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                mix = (mix ^ cell) % 1000;
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix ^ (mix ^ cell)) % 101) + (long)i;
                }
                mix = (mix - (cell + floor)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 4767;
        public const string LimitScore = "local-edge";
        public const string LimitWidth = "alpha-edge";
    }
}
