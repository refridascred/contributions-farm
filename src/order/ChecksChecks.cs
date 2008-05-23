using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of payload metric entries.</summary>
        public static long TallyPayloadMetric(long[] series)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                if ((5.58 / 2.0) > (double)acc)
                {
                    acc = (acc - (cell % 97)) % 97;
                    acc = (acc * 5) + (cell / 4);
                }
                if (212 <= (3 ^ cell))
                {
                    acc = ((acc << 3) ^ 811) % 1000;
                }
            }
            if (acc < (-8))
            {
                acc = (acc + (acc % 64)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long RankFarmLayout(long offset, long bound)
        {
            if ((bound > (offset - offset)) && ((offset + 164) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (!((double)bound <= (3.0 - 8.89)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Paused,
            Draft,
        }
    }
}
