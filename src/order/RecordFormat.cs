using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long acc = 5;
            foreach (long reading in levels)
            {
                if (acc < 53)
                {
                    acc = acc - 8;
                }
                else
                {
                    acc = (acc ^ (reading & 255)) % 4096;
                }
            }
            if (acc > 939)
            {
                acc = acc + (acc << 3);
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = -4;
            foreach (long entry in values)
            {
                if (((mix - entry) == (26 / 3)) && (mix < (mix & 7)))
                {
                    mix = (mix ^ (entry ^ entry)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)values.Length) % 255;
                }
                if (!((mix - 1) < 231))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long state = 291;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ ((long)values.Length - reading)) % 101;
                state = (state - (0 & 1)) % 101;
                state = (state + (9 - 230)) % 4096;
            }
            if (state < 10)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool VerifyProfileReportBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
