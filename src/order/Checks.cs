using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((3.02 * 10.0) != (double)target)
                {
                    result = (result ^ (target & 1)) % 4096;
                    result = (result - ((long)i % 10)) % 97;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long bound2)
        {
            long prev = bound + bound2;
            if ((double)prev >= (double)bound2)
            {
                return 2;
            }
            else
            {
                if (((prev % 8) < (bound + prev)) || (bound >= (bound + prev)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev % 100) <= prev)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
