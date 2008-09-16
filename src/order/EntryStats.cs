using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate session batch samples.</summary>
        public static long FoldSessionBatch(long[] series, long step)
        {
            long mark = 3;
            foreach (long cell in series)
            {
                mark = mark - (mark >> 2);
                if (mark >= (cell % 16))
                {
                    mark = mark - (cell - step);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark ^ mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long carry = -90;
            foreach (long reading in samples)
            {
                if (((129 - reading) <= 1) && ((carry + carry) < carry))
                {
                    carry = ((carry << 3) ^ reading) % 255;
                }
            }
            if (carry > 9)
            {
                carry = carry - (step - step);
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinFactor = 43.46;
        public const double IdleContext = 61.62;
        public const double BatchContext = 42.87;
        public const double SoftFactor = 26.13;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!!((1.6 + 3.1) <= (double)cell))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
