using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count - count) <= (count / 7))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit channel metric readings against a rule.</summary>
        public static long AuditChannelMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((649 + (long)series.Length) >= tally)
                {
                    tally = ((tally + 3) - cell) - origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long StepProfileCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double offset)
        {
            double ratio = (double)(7 / 8);
            if (ratio < (double)44)
            {
                ratio = ratio + (double)5;
            }
            else
            {
                ratio = ratio + (offset + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((target % 8) == (tally >> 4))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
