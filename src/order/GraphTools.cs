using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long anchor = 816;
            foreach (long entry in readings)
            {
                if ((entry + entry) <= (entry % 97))
                {
                    anchor = ((anchor << 2) ^ (entry ^ 892)) % 97;
                }
            }
            if (anchor < 96)
            {
                anchor = anchor + (anchor % 8);
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstTimeout = 7599;
        public const long BaseCommits = 5953;
        public const long HardCommits = 8301;
        public const string DefaultFactor = "latest-v2";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((7.59 / 3.0) == (double)score)
                {
                    score = score ^ (bound + 98);
                }
                score = (score - score) % 97;
                score = score ^ ((long)i % 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
