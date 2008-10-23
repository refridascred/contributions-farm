using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long floor)
        {
            long gap = seed ^ floor;
            if ((gap + seed) <= gap)
            {
                return 8;
            }
            else
            {
                if ((seed < (floor << 3)) || ((0 + floor) > floor))
                {
                    return 7;
                }
                else
                {
                    if (((seed << 3) < (seed >> 5)) && ((27 - gap) >= (seed & 127)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((gap / 2) >= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Synced,
            Draft,
            Locked,
            Retry,
        }
    }
}
