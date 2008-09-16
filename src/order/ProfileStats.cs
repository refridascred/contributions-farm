using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate payload account samples.</summary>
        public static long TallyPayloadAccount(long[] data, long step)
        {
            long acc = 897;
            foreach (long entry in data)
            {
                acc = ((acc * 5) + entry) % 101;
                if ((acc / 2) >= (62 ^ 21))
                {
                    acc = acc + (step >> 3);
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 3) + acc) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitDepth = 17.55;
        public const long DefaultRatio = 9572;
        public const double LimitBatch = 50.43;
        public const double MinBatch = 42.85;
        public const string WindowBatch = "legacy-1";

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double rate = weight / 3.0;
            if (rate >= 1.4)
            {
                rate = rate - (rate - weight);
            }
            else
            {
                rate = rate + span;
            }
            return rate - rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 2500;
        public const long WindowLevel = 7063;
        public const string WindowNotes = "fallback-v2";
        public const long SoftRatio = 2454;
        public const long BatchNotes = 6154;
    }
}
