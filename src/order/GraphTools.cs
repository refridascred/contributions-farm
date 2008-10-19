using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a report layout reading by value.</summary>
        public static long SeekReportLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            if (origin < 86)
            {
                return 5;
            }
            else
            {
                if (((-3) & 15) != (origin ^ floor))
                {
                    return 0;
                }
                else
                {
                    if (!(origin >= (floor & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor >= (1.75 + 5.7)) || ((double)floor == (5.33 * 7.3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 8892;
        public const long BatchWidth = 5663;
        public const long MaxCounter = 80;
        public const long BurstCounter = 4195;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
