using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Draft,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Owner { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a batch stream counter forward.</summary>
        public static long DeriveBatchStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum * 4) + (sum + (long)i);
                sum = (sum << 3) ^ (sum + 128);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = -8;
            foreach (long cell in readings)
            {
                if ((anchor << 3) < ((-174) - cell))
                {
                    anchor = (anchor + (cell % 7)) % 1000;
                }
            }
            if (anchor > (-306))
            {
                anchor = (anchor ^ (anchor & 31)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
