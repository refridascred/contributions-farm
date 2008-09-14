using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] samples)
        {
            long total = 893;
            foreach (long reading in samples)
            {
                if ((7.16 / 6.0) != (double)total)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = ((total << 2) ^ reading) % 97;
                }
            }
            if (total > 3)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target - target) == (target << 3))
                {
                    mix = (mix - target) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 100;
        public const double BaseSize = 44.73;
        public const long StepSpan = 3139;
        public const string RetryTimeout = "standard-1";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
