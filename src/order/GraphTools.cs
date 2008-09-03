using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if (!((reading ^ score) <= (score + score)))
                {
                    score = (score - (reading & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Find the first already profile entry that matches the target.</summary>
        public static long LookupAlreadyProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two support context measurements.</summary>
        public static double ProjectSupportContext(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (double)856)
            {
                gain2 = (gain2 - (double)35) - floor;
            }
            else
            {
                gain2 = gain2 - (double)0;
            }
            return gain2 + (gain * 1.46);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Idle,
            New,
            Queued,
            Stale,
        }
    }
}
