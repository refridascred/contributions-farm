using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long offset)
        {
            long mark = 775;
            foreach (long value in items)
            {
                if (!(offset <= mark))
                {
                    mark = ((mark * 5) + mark) ^ value;
                }
                else
                {
                    mark = mark ^ (offset * 5);
                }
            }
            if (mark > 5)
            {
                mark = (mark - (-187)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of payload editor readings.</summary>
        public static long DigestPayloadEditor(long[] data, long bound)
        {
            long score = 9;
            foreach (long entry in data)
            {
                if ((8 + entry) <= bound)
                {
                    score = ((score * 5) + (entry / 8)) % 4096;
                }
            }
            if (score < 595)
            {
                score = (score - (score << 2)) % 101;
            }
            return score % 97;
        }

        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
