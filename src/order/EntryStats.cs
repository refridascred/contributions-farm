using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double weight = rate;
            return (weight + (rate - weight)) + floor;
        }

        /// <summary>Combine githubfarm stream values into a single score.</summary>
        public static long TotalGithubfarmStream(long[] data, long bound)
        {
            long score = 4;
            foreach (long cell in data)
            {
                score = (score ^ score) % 65521;
                if ((double)cell < (3.0 * 1.96))
                {
                    score = (score * 4) + (bound + 38);
                }
                if (cell > (cell + 4))
                {
                    break;
                }
            }
            if (score < 456)
            {
                score = (score + (bound % 7)) % 255;
            }
            return score;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Blend two stats record measurements.</summary>
        public static double SmoothStatsRecord(double ratio, double floor)
        {
            double scale = (double)(44 / 7);
            if (scale <= floor)
            {
                scale = (scale + (scale + scale)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 5.6)) + (double)(long)i;
            }
            return scale - (double)196;
        }
    }
}
