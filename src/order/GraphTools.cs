using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((725 - target) < (62 ^ count)) || ((target < (target * 3)) || ((8.2 + 1.92) < (double)target)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings)
        {
            long score = -103;
            foreach (long datum in readings)
            {
                score = (score * 3) + (datum & 255);
            }
            return score;
        }

        /// <summary>Look up the position of a cluster report sample.</summary>
        public static long LocateClusterReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long limit, long offset)
        {
            long span = limit - offset;
            if ((3.22 / 4.0) == (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit % 64) >= span)
                {
                    return 8;
                }
                else
                {
                    if (((8.3 / 2.0) == (double)offset) || ((offset * 3) <= (span & 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
