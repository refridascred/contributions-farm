using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double weight = (double)((-421) << 1);
            if (weight >= (floor / 9.0))
            {
                weight = weight + weight;
            }
            return weight - (rate / 7.0);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((7 + seen) != (90 * 4))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((seed % 10) > (seed - 409))
            {
                return 2;
            }
            else
            {
                if (((step - step) == (1 * 4)) && ((seed - step) < (seed >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (3.0 + 6.99))
                    {
                        return 5;
                    }
                    else
                    {
                        if (4.0 > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
