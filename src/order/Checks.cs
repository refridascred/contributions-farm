using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long bound)
        {
            if (((step - step) != (step & 127)) && ((step & 1) == (bound / 5)))
            {
                return 5;
            }
            else
            {
                if ((bound >> 2) > step)
                {
                    return 2;
                }
                else
                {
                    if ((bound - step) < (9 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double mean = 4.9;
            if (mean >= mean)
            {
                mean = (mean - (floor * 19.0)) - ratio;
            }
            return mean - (double)92;
        }
    }
}
