using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long floor)
        {
            if (((-73) << 2) <= (origin - floor))
            {
                return 8;
            }
            else
            {
                if (((4.5 * 6.0) < (double)origin) && ((245 + floor) < (13 >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) == (floor ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.75 + 16.0) != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if ((double)offset >= 15.0)
                {
                    result = (result + (entry - entry)) % 97;
                    result = result - (result >> 3);
                }
                if ((result + offset) >= (result + 6))
                {
                    result = (result ^ (result * 5)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (offset << 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Scale a payload channel figure with a bias.</summary>
        public static double SmoothPayloadChannel(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)2)
            {
                ratio2 = ratio2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (ratio - bias)) - (double)(long)i;
            }
            return ratio2 - (double)4;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
