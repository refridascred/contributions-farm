using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                if (!(score <= (score + score)))
                {
                    score = (score - (reading >> 4)) % 101;
                }
                if (score > (score % 16))
                {
                    score = score - (39 >> 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            New,
            Draft,
            Closed,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double drift = weight;
            if (drift > 10.0)
            {
                drift = drift - (span + drift);
            }
            else
            {
                drift = drift + (drift - 6.57);
            }
            return drift - (drift + 6.8);
        }
    }
}
