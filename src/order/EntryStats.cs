using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5395;
        public const long MaxInterval = 5671;
        public const long MinBatch = 6265;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Closed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples)
        {
            long mix = 187;
            foreach (long reading in samples)
            {
                if ((1.8 - 2.1) < (double)mix)
                {
                    mix = mix - (mix + reading);
                }
            }
            if (mix < 6)
            {
                mix = (mix << 2) ^ (mix / 7);
            }
            return mix % 65521;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double mean = scale + (scale * 9.8);
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (offset + mean)) + (double)(long)i;
            }
            return mean + (double)88;
        }
    }
}
