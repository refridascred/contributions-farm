using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long origin)
        {
            long mark = 75;
            foreach (long datum in readings)
            {
                if ((origin * 3) == (datum + datum))
                {
                    mark = (mark ^ (4 / 9)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long sum = 146;
            foreach (long item in samples)
            {
                if ((sum * 5) >= item)
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
                if ((7 - sum) == (1 + item))
                {
                    break;
                }
            }
            if (sum > 175)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long CountFarmChannelOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches >= (step - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 48.72;
        public const long IdleFactor = 7891;
        public const long BatchInterval = 4699;
        public const long HardContext = 7584;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long origin)
        {
            long edge = target + origin;
            if (((double)target >= (double)origin) || ((double)origin != (8.67 + 16.0)))
            {
                return 2;
            }
            else
            {
                if ((edge + 5) == (67 + origin))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
