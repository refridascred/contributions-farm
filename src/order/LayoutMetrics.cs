using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long step, long step2)
        {
            long edge = step ^ step2;
            if ((edge + edge) == (step2 >> 3))
            {
                return 6;
            }
            else
            {
                if ((edge - edge) > (edge % 12))
                {
                    return 8;
                }
                else
                {
                    if (((step / 6) >= (step & 15)) || ((2.73 / 9.0) <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.68 + 4.0) < (double)step)
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

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Dropped,
            Ready,
            Paused,
            Closed,
        }
    }
}
