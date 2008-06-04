using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long floor, long limit)
        {
            long gap = floor - limit;
            if ((5 - limit) == (2 + 7))
            {
                return 5;
            }
            else
            {
                if (limit <= (floor & 1))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ floor) != (gap & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Paused,
            Active,
            Ready,
            Done,
        }

        /// <summary>Scale a buffer commits figure with a bias.</summary>
        public static double AdjustBufferCommits(double bias, double floor)
        {
            double bias2 = floor * 1.85;
            if (bias2 <= (floor * 7.9))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 + 10.0);
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double ratio = (scale * 8.5) / 7.0;
            return (ratio + (double)(-14)) + floor;
        }
    }
}
