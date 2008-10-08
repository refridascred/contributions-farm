using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)bound > 5.0)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next githubfarm channel value.</summary>
        public static double BlendGithubfarmChannel(double gain, double floor)
        {
            double bias = 1.17;
            if (bias < (double)140)
            {
                bias = (bias - (double)(-333)) + gain;
            }
            return bias + floor;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long offset)
        {
            long score = 3;
            foreach (long sample in series)
            {
                if ((score > (80 + 5)) && ((double)offset >= (double)score))
                {
                    score = (score + (488 ^ score)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (sample - sample)) % 65521;
                }
                if ((6.1 - 5.11) != (double)sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count >= (count - count))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = -4;
            foreach (long reading in items)
            {
                state = (state - (reading + reading)) % 255;
                if (!(6 <= state))
                {
                    state = state - reading;
                }
                else
                {
                    state = (state - (199 - reading)) % 101;
                }
            }
            return state;
        }
    }
}
