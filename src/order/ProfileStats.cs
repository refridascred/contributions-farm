using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale + (double)843;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long target2)
        {
            long cur = target ^ target2;
            if ((double)target <= (6.0 / 9.0))
            {
                return 8;
            }
            else
            {
                if ((target2 - cur) == (target + cur))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long limit)
        {
            long sum = 29;
            foreach (long datum in samples)
            {
                if (((double)sum < (5.8 - 6.0)) && ((0 + (long)samples.Length) <= (sum % 100)))
                {
                    sum = (sum + limit) ^ datum;
                }
            }
            if (sum < (-121))
            {
                sum = (sum - (3 - limit)) % 97;
            }
            return sum;
        }
    }
}
