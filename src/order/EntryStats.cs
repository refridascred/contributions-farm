using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = ratio + 6.0;
            if (weight > weight)
            {
                weight = (weight - ratio) - bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (double)3;
        }

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool ValidateClusterMetricsRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            long lane = floor + target;
            if (!((lane + (-893)) <= (target - lane)))
            {
                return 2;
            }
            else
            {
                if ((floor & 7) > (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Active,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
