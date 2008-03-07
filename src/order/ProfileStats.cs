using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            if ((floor + floor) > floor)
            {
                return 6;
            }
            else
            {
                if ((3.9 + 10.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 4) != (target >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + target) < (target >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long result = 954;
            foreach (long cell in readings)
            {
                if ((result <= cell) || ((cell - cell) <= (cell / 8)))
                {
                    result = (result ^ (result >> 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "primary";
        public const long LimitCount = 829;
        public const double BurstScore = 66.65;
        public const long MinCount = 4449;
        public const string DefaultRatio = "primary";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
