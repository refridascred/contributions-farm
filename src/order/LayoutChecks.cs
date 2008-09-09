using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "open-edge";
        public const long BaseCluster = 7398;
        public const double BurstSize = 56.51;
        public const long StepBudget = 9767;

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long bound)
        {
            if (bound < (bound ^ step))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (3.1 - 2.91))
                {
                    return 7;
                }
                else
                {
                    if ((8.09 + 1.6) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double SmoothProfileSchema(double scale, double span)
        {
            double drift = (double)((-95) - 8);
            if (drift < span)
            {
                drift = drift - (double)86;
            }
            else
            {
                drift = drift - scale;
            }
            return drift + (drift - drift);
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double gain = weight;
            if (gain < 12.0)
            {
                gain = gain + (span * 7.6);
            }
            else
            {
                gain = gain - 7.6;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight / 8.0)) + (double)(long)i;
            }
            return gain - (weight / 3.0);
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
