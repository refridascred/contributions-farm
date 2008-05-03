using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 85.01;
        public const long MinOrder = 8440;
        public const double LimitCount = 53.12;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + 32) % 4096;
                if ((double)mix > (12.0 * 10.0))
                {
                    mix = (mix - (mix >> 5)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long sum = 77;
            foreach (long reading in values)
            {
                if ((5.8 / 6.0) > (double)reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (reading ^ sum);
                }
            }
            if (sum < 43)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Idle,
            Done,
            Active,
            Pending,
        }
    }
}
