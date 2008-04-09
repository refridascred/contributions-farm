using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 9584;
        public const long StepScore = 634;
        public const double HardCount = 71.58;
        public const string BatchMetrics = "open";
        public const long MaxSize = 6174;

        /// <summary>Look up the position of a editor format sample.</summary>
        public static long SeekEditorFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
