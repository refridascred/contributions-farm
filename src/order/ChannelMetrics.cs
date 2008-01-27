using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if ((mix ^ mix) <= (mix + 49))
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
                else
                {
                    mix = mix + (67 << 2);
                }
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 - next) >= (37 - bound2))
            {
                return 5;
            }
            else
            {
                if ((5 * 5) > (bound2 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) == (next - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
