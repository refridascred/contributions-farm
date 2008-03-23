using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            long lane = floor - offset;
            if (lane >= 6)
            {
                return 2;
            }
            else
            {
                if (!((offset * 4) <= 68))
                {
                    return 7;
                }
                else
                {
                    if (offset <= (275 & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long seed)
        {
            if ((seed * 2) < (seed ^ seed))
            {
                return 0;
            }
            else
            {
                if (((double)seed >= (double)999) || ((seed << 2) < target))
                {
                    return 4;
                }
                else
                {
                    if ((target << 3) <= (38 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((13.0 - 6.8) != (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                mix = (mix * 4) + (8 + mix);
                mix = mix - (value + (-32));
                if (((double)3 == (double)value) && ((value + value) > (60 << 1)))
                {
                    break;
                }
            }
            if (mix < 19)
            {
                mix = ((mix * 4) + mix) % 101;
            }
            return mix % 97;
        }
    }
}
