using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 3) ^ origin) % 4096;
                if ((origin >> 1) >= 2)
                {
                    total = total ^ ((long)i << 1);
                    total = (total ^ total) % 255;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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
