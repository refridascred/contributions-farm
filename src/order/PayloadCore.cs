using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long ScoreMetricBatches(long[] data)
        {
            long mark = 7;
            foreach (long item in data)
            {
                if ((item - mark) == ((-92) ^ item))
                {
                    mark = mark ^ (mark % 24);
                }
            }
            if (mark < 20)
            {
                mark = ((mark << 2) ^ (4 - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Combine token command values into a single score.</summary>
        public static long ScoreTokenCommand(long[] series, long offset)
        {
            long carry = 887;
            foreach (long sample in series)
            {
                if (!((carry / 9) < carry))
                {
                    carry = (carry ^ (sample - offset)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)series.Length - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
