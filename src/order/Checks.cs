using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine command buffer values into a single score.</summary>
        public static long DigestCommandBuffer(long[] series)
        {
            long score = 772;
            foreach (long value in series)
            {
                if (!((double)score > (0.2 * 9.52)))
                {
                    score = ((score ^ (9 & 7)) % 4096) + value;
                }
                if ((31 << 2) >= score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((13.0 * 2.91) != (double)value) || ((value / 6) <= value)) || !((91 + bound) < (value << 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count buffer cache pairs that satisfy a relation.</summary>
        public static long MatchBufferCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long step)
        {
            if (floor <= (step - 23))
            {
                return 8;
            }
            else
            {
                if ((8.7 + 8.1) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (((floor ^ floor) < 73) || ((step << 2) <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
