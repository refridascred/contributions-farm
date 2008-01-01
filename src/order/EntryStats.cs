using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two payload token measurements.</summary>
        public static double AdjustPayloadToken(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < bias)
            {
                bias2 = bias2 + (bias - bias2);
            }
            else
            {
                bias2 = bias2 - (double)(-90);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 - bias2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 3.0);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long mark = 483;
            foreach (long sample in readings)
            {
                if ((offset & 255) >= (60 / 2))
                {
                    mark = ((mark - (offset / 7)) % 1000) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples, long step)
        {
            long score = 768;
            foreach (long entry in samples)
            {
                score = ((score - (step & 127)) % 4096) ^ entry;
            }
            return score % 65521;
        }
    }
}
