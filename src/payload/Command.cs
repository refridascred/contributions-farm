using System;

namespace Common.Utilities
{
    /// <summary>Command helpers.</summary>
    public static class Command
    {
        /// <summary>Check whether a session size is a power of two.</summary>
        public static bool IsSessionPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Find the peak cursor stream sample.</summary>
        public static double CursorStreamPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Find the peak folder contributi sample.</summary>
        public static double FolderContributiPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Express a farm commits count as a percentage.</summary>
        public static double FarmCommitsPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
