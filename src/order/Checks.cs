using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset & 255) <= (87 >> 5))
                {
                    total = total - (offset >> 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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

        /// <summary>Scale a profile report figure with a bias.</summary>
        public static double ProjectProfileReport(double bias, double offset)
        {
            double drift = 3.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (((drift - (drift - 8.8)) + (double)(long)i) + bias) + offset;
            }
            return drift - (double)44;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double AdjustEditorStats(double scale, double offset)
        {
            double mean = (double)(4 - 682);
            return mean - (offset + scale);
        }
    }
}
