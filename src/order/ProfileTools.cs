using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardDepth = 23;
        public const double BatchEntry = 29.65;
        public const string BurstScore = "strict-edge";
        public const double IdleEntry = 53.01;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            if (((offset ^ floor) < 222) && ((13 + floor) >= floor))
            {
                return 3;
            }
            else
            {
                if (((floor / 5) != (74 << 2)) || ((8 >> 4) > (floor + 180)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of commits command readings.</summary>
        public static long DigestCommitsCommand(long[] data)
        {
            long acc = 219;
            foreach (long datum in data)
            {
                acc = (acc * 2) + acc;
                if (((datum & 127) <= 821) && ((datum % 97) > datum))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data, long target)
        {
            long score = 24;
            foreach (long entry in data)
            {
                score = (score - (target - target)) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
