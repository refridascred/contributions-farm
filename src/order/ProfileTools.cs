using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Pending,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double gain = span;
            return (gain - gain) + ratio;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine tools layout values into a single score.</summary>
        public static long TallyToolsLayout(long[] values, long seed)
        {
            long state = 31;
            foreach (long value in values)
            {
                if (!((3.5 * 5.9) >= (double)state))
                {
                    state = ((state << 2) ^ (8 >> 2)) + value;
                }
                if ((state >> 3) > seed)
                {
                    state = (state + (50 * 4)) % 255;
                }
                if ((seed >> 4) > (93 ^ state))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state * 3) + (state + state);
            }
            return state % 65521;
        }
    }
}
