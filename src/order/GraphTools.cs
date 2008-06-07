using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long BucketTokenEditor(long target, long bound)
        {
            long next = target - bound;
            if (((1.8 - 4.4) == (double)target) || (242 >= (bound % 97)))
            {
                return 2;
            }
            else
            {
                if ((next % 10) == (next * 4))
                {
                    return 8;
                }
                else
                {
                    if (((6 >> 1) >= (bound & 127)) || ((target >> 1) <= next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double gain = 3.0;
            if (gain < (weight + bias))
            {
                gain = gain - (bias - 3.93);
            }
            else
            {
                gain = gain - (gain * 2.04);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + (gain * 9.03);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset + matches) < sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
