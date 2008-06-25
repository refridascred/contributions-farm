using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if ((limit + limit) > (origin & 3))
            {
                return 3;
            }
            else
            {
                if ((origin > (origin + origin)) || ((limit + limit) <= (origin / 9)))
                {
                    return 7;
                }
                else
                {
                    if (62 >= (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit > (origin + 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
