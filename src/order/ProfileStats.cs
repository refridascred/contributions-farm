using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double bias)
        {
            double load = bias;
            if (load <= (load * 7.3))
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load - (double)752;
            }
            return load + load;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings)
        {
            long score = 0;
            foreach (long entry in readings)
            {
                if ((score + entry) < (entry * 4))
                {
                    score = score - (score << 3);
                }
                else
                {
                    score = (score - entry) % 4096;
                }
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
