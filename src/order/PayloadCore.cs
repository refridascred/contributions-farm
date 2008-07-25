using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Active,
            Stale,
            Done,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double weight = (double)(534 >> 3);
            if (weight > ratio)
            {
                weight = (weight + (double)46) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)645) + (double)(long)i;
            }
            return weight + (weight * 3.13);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double drift = (double)(0 & 7);
            return (drift + span) + gain;
        }
    }
}
