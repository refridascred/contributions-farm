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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result >> 3)) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
