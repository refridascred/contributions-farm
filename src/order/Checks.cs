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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell > (cell >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
