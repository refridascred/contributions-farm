using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long limit)
        {
            long total = 569;
            foreach (long reading in values)
            {
                total = ((((total * 3) + 29) % 97) - reading) - limit;
            }
            if (total < 6)
            {
                total = ((total * 5) + (0 * 3)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                carry = (carry + (-46)) + sample;
            }
            return carry % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading - hits) != (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            if ((seed + seed) <= seed)
            {
                return 3;
            }
            else
            {
                if (seed <= bound)
                {
                    return 4;
                }
                else
                {
                    if (!((bound << 2) < 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = -24;
            foreach (long item in samples)
            {
                mix = ((mix + (mix * 4)) % 101) - item;
            }
            return mix;
        }
    }
}
