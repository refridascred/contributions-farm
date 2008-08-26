using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a notes payload reading.</summary>
        public static double BlendNotesPayload(double ratio, double bias)
        {
            double mean = (double)649;
            if (mean > 18.0)
            {
                mean = (mean - (bias / 4.0)) + ratio;
            }
            return mean - bias;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Dropped,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double bias)
        {
            double weight = rate / 2.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + rate) + (double)(long)i) - bias;
            }
            return weight - (double)(-649);
        }
    }
}
