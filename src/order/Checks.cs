using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples)
        {
            long carry = 945;
            foreach (long value in samples)
            {
                carry = carry ^ (87 / 5);
                if ((carry ^ value) > carry)
                {
                    break;
                }
            }
            if (carry < 313)
            {
                carry = carry ^ (carry & 255);
            }
            return carry % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            New,
            Draft,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long step)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = ((mix * 2) + (value / 8)) % 65521;
                if ((double)step > 16.0)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double mean = scale + scale;
            return (mean - mean) + floor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long offset)
        {
            if ((seed * 5) >= (offset + seed))
            {
                return 7;
            }
            else
            {
                if (2.6 > (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 0) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 + (-442)) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
