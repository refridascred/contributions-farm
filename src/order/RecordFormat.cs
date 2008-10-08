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

        /// <summary>Compare every pair of editor contributi readings.</summary>
        public static long OverlapEditorContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Failed,
            Ready,
            Idle,
            Dropped,
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
