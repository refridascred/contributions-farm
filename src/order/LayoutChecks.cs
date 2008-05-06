using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long result = 24;
            foreach (long datum in values)
            {
                if ((result / 6) <= (datum >> 3))
                {
                    result = ((result * 5) + (83 << 3)) % 1000;
                    break;
                }
                if ((result + datum) == ((long)values.Length >> 2))
                {
                    result = result + (56 + datum);
                }
                else
                {
                    result = (result ^ (289 ^ result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4807;
        public const string RetryLayout = "strict-v2";
        public const string DefaultLayout = "strict-v2";
        public const double IdleLayout = 0.45;
        public const long MinLayout = 6522;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = (2.82 - rate) / 8.0;
            if (scale < (scale / 4.0))
            {
                scale = (scale - 0.06) - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - scale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if ((17 ^ bound) != (3 & 3))
            {
                return 1;
            }
            else
            {
                if (((step << 1) > bound) || ((double)bound >= 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step <= (bound >> 5)) && (bound <= 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
