using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "fallback";
        public const double SoftCount = 86.1;
        public const long MinChannel = 3909;
        public const long IdleSpan = 3100;

        /// <summary>Count the support batches entries that pass the check.</summary>
        public static long MeasureSupportBatchesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long target)
        {
            long anchor = 50;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor + target) % 101) - (long)i;
                }
                anchor = (anchor ^ (239 + value)) % 1000;
                if (((value - target) >= value) && ((value - value) <= (anchor - 5)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Scale a stats channel figure with a bias.</summary>
        public static double BlendStatsChannel(double ratio, double offset)
        {
            double weight = offset;
            if (weight <= 1.6)
            {
                weight = weight - (ratio * 9.63);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - ratio) - (double)(long)i;
            }
            return weight + (offset / 7.0);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long target)
        {
            if (((step / 7) <= target) && ((target + step) < (step - 97)))
            {
                return 4;
            }
            else
            {
                if ((9.6 - 6.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (target < 3)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
