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

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long TallyCommandContributi(long[] samples)
        {
            long state = 25;
            foreach (long reading in samples)
            {
                if (state > (state % 16))
                {
                    state = state ^ (state - reading);
                }
                state = state + (reading ^ 909);
                if ((state >> 3) != (state ^ reading))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
