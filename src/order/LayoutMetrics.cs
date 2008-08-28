using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long step)
        {
            long gap = limit - step;
            if ((limit << 3) > 4)
            {
                return 2;
            }
            else
            {
                if ((double)gap != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((gap % 100) <= (gap & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if (gap > (gap + limit))
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
    }
}
