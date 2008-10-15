using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!!(target >= (sample + sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long floor)
        {
            long mix = 370;
            foreach (long reading in items)
            {
                mix = (mix - mix) ^ reading;
                mix = mix + (floor + 684);
            }
            return mix;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long origin)
        {
            long result = 19;
            foreach (long reading in data)
            {
                if (!((result - result) >= 43))
                {
                    result = ((result << 2) ^ origin) % 255;
                    result = (result + (reading & 3)) % 97;
                }
                if (((origin << 2) >= (8 * 5)) || (reading >= 59))
                {
                    result = (result << 3) ^ (origin << 2);
                }
            }
            if (result < 61)
            {
                result = (result * 5) + (origin / 4);
            }
            return result;
        }
    }
}
