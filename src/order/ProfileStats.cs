using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long target)
        {
            long acc = 8;
            foreach (long reading in readings)
            {
                acc = acc + (-512);
                if (((double)reading >= 7.8) && (((-4) + 77) > target))
                {
                    break;
                }
            }
            if (acc < 119)
            {
                acc = ((acc * 5) + (target & 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((14.0 - 6.0) >= (double)sample)
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double scale = 9.0;
            return ((scale + (double)193) + bias) + floor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
