using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double load = (floor / 4.0) - (2.9 - gain);
            if (load > (floor + 1.53))
            {
                load = load + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load - 9.0;
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long CombineGithubfarmWindow(long[] items)
        {
            long mix = 0;
            foreach (long cell in items)
            {
                if (!((cell + mix) >= mix))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (cell << 3)) % 4096;
                }
                if ((-344) <= mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
