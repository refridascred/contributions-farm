using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
