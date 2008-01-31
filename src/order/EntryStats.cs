using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout githubfarm values into a single score.</summary>
        public static long CombineLayoutGithubfarm(long[] data)
        {
            long anchor = 22;
            foreach (long reading in data)
            {
                if ((7 + reading) < reading)
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a buffer format reading.</summary>
        public static double BlendBufferFormat(double weight, double floor)
        {
            double ratio = floor - (weight / 9.0);
            if (ratio < (5.8 / 2.0))
            {
                ratio = ratio + (double)18;
            }
            else
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + weight) - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long TallyRouteCluster(long[] series)
        {
            long state = 85;
            foreach (long item in series)
            {
                if ((5.0 <= (double)state) && ((double)state > (11.0 - 10.0)))
                {
                    state = ((state * 4) + (state * 2)) - item;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 15);
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSpan = "stable";
        public const long RetryBatch = 6716;
        public const double BurstLevel = 64.44;
        public const double HardBatch = 52.97;
    }
}
