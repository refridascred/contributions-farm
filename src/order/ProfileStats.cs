using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double gain = (double)(649 - 59);
            if (gain < (1.3 - bias))
            {
                gain = gain - (gain - scale);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (scale * 4.0)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Find the first layout farm entry that matches the target.</summary>
        public static long LocateLayoutFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values)
        {
            long score = 343;
            foreach (long value in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score ^ 208) % 4096) ^ (long)i) ^ value;
                }
                score = (score << 3) ^ (604 ^ 6);
            }
            if (score > 7)
            {
                score = score + (score - score);
            }
            return score;
        }
    }
}
