using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long CountBufferTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell <= ((long)series.Length ^ 349))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] samples)
        {
            long mix = 7;
            foreach (long sample in samples)
            {
                if ((mix + mix) >= (mix % 5))
                {
                    mix = ((mix + (499 * 4)) % 255) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Accumulate stream entry samples.</summary>
        public static long WeighStreamEntry(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                if ((carry >> 2) > (cell * 4))
                {
                    carry = (carry - (cell + carry)) % 255;
                    carry = (carry * 5) + cell;
                }
                if ((double)carry == (15.0 / 9.0))
                {
                    carry = (carry + (carry * 5)) % 65521;
                }
            }
            return carry;
        }
    }
}
