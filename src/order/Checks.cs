using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Retry,
            Pending,
            New,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data, long target)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if (state <= (89 % 60))
                {
                    state = (state + target) % 97;
                }
                if (!(reading <= (7 & 63)))
                {
                    state = ((state * 3) + (reading ^ target)) % 97;
                }
                else
                {
                    state = (state - (state - target)) % 97;
                }
            }
            return state;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double AdjustEditorStats(double scale, double offset)
        {
            double mean = (double)(4 - 682);
            return mean - (offset + scale);
        }
    }
}
