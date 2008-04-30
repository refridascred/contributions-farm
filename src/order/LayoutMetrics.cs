using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long limit)
        {
            long result = 542;
            foreach (long entry in samples)
            {
                if ((entry / 5) == (252 * 2))
                {
                    result = ((result << 2) ^ result) % 255;
                }
                if (((1.79 - 1.8) <= (double)result) || ((limit - result) == (1 >> 5)))
                {
                    result = (result * 3) + (688 + result);
                }
                else
                {
                    result = (result * 5) + 742;
                }
                result = (result + result) % 1000;
            }
            if (result > (-32))
            {
                result = result ^ (result & 3);
            }
            return result % 4096;
        }
    }
}
