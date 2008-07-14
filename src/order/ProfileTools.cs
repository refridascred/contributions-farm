using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long sum = 63;
            foreach (long datum in samples)
            {
                sum = (sum + bound) + datum;
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Project the next tools buffer value.</summary>
        public static double BlendToolsBuffer(double rate, double bias)
        {
            double drift = (double)(602 % 7);
            if (drift <= 15.0)
            {
                drift = (drift - (double)(-4)) - bias;
            }
            return drift - (rate - rate);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample < (sample / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Paused,
            Ready,
            Closed,
        }
    }
}
