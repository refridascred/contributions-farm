using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a tools checks reading by value.</summary>
        public static long LocateToolsChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double offset)
        {
            double bias = 4.0;
            if (bias < (8.9 * 5.56))
            {
                bias = ((bias - (bias - bias)) + gain) + offset;
            }
            return bias - (4.0 + 7.37);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Idle,
            Stale,
            Done,
        }
    }
}
