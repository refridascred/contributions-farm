using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count format cache pairs that satisfy a relation.</summary>
        public static long CompareFormatCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long floor)
        {
            if (((floor % 24) > (floor + origin)) || ((4.34 / 2.0) != (double)origin))
            {
                return 6;
            }
            else
            {
                if (41 >= (origin << 3))
                {
                    return 7;
                }
                else
                {
                    if ((4 <= (floor + floor)) && ((double)origin >= (7.0 - 2.5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((565 ^ (-45)) >= (floor << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Retry,
            Done,
            Paused,
        }
    }
}
