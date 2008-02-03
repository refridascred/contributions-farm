using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((14.0 * 9.6) <= (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long sum = 37;
            foreach (long datum in levels)
            {
                sum = (sum - 0) % 101;
                sum = (sum * 3) + (63 % 12);
                if ((sum & 15) >= (datum + datum))
                {
                    break;
                }
            }
            if (sum < 16)
            {
                sum = ((sum * 5) + (sum / 7)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Active,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((9.7 - 9.19) != (double)state))
                {
                    state = ((state * 3) + ((-183) - state)) % 65521;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 3) + ((-746) & 1)) ^ (long)i2;
                }
                state = (state - (floor + floor)) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
