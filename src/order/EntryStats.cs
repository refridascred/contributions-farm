using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long TallyStatsSupport(long[] readings)
        {
            long carry = 8;
            foreach (long sample in readings)
            {
                if (sample < (896 * 5))
                {
                    carry = carry + (890 / 6);
                }
                else
                {
                    carry = (carry << 2) ^ ((-30) & 255);
                }
            }
            if (carry > 4)
            {
                carry = (carry ^ ((long)readings.Length % 24)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double rate = 15.0;
            if (rate > ratio)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + (4.41 - rate);
        }
    }
}
