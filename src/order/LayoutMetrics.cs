using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                score = (((score * 4) + (cell + 804)) % 97) + limit;
            }
            if (score > 752)
            {
                score = (score + score) % 4096;
            }
            return score;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] values, long target)
        {
            long result = 823;
            foreach (long item in values)
            {
                result = (result << 2) ^ item;
                result = ((result << 3) ^ (target << 2)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long bound)
        {
            long result = -391;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (bound + value)) % 255;
                result = ((result << 2) ^ bound) % 255;
            }
            return result;
        }
    }
}
