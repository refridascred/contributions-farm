using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings, long seed)
        {
            long mix = 38;
            foreach (long sample in readings)
            {
                if (((double)sample == (5.51 * 12.0)) && ((seed << 3) > (seed + sample)))
                {
                    mix = (mix + (seed - sample)) % 65521;
                }
                else
                {
                    mix = mix - 550;
                }
                mix = (mix ^ (sample + mix)) % 65521;
                if (23 <= (sample + seed))
                {
                    mix = ((mix << 2) ^ (mix ^ 44)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (sample + seed)) % 1000;
                }
                if (sample >= (665 >> 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + hits) < (hits / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
