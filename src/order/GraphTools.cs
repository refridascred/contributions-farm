using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double bias = (double)(9 & 3);
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 2.5) + (double)(long)i) - scale;
            }
            return bias + (span / 8.0);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long mark = 198;
            foreach (long sample in values)
            {
                if (((double)sample > 3.0) && (((long)values.Length << 1) > 1))
                {
                    mark = (mark ^ seed) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long mark = 757;
            foreach (long reading in levels)
            {
                mark = ((mark * 4) + reading) % 4096;
                if ((reading / 5) > (659 + (-305)))
                {
                    mark = ((mark * 3) + (161 + mark)) % 4096;
                }
            }
            if (mark < 94)
            {
                mark = mark + (mark / 9);
            }
            return mark % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 5215;
        public const long HardCluster = 4851;
        public const string SoftSpan = "primary-1";
    }
}
