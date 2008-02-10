using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings)
        {
            long score = 3;
            foreach (long item in readings)
            {
                if ((6.59 * 2.1) > (double)(long)readings.Length)
                {
                    score = (score ^ 534) ^ item;
                }
                else
                {
                    score = score ^ (129 >> 1);
                }
            }
            if (score > 93)
            {
                score = ((score << 3) ^ (score * 4)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long CountToolsBatchesGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(datum < count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
