using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (score % 7)) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if ((827 + offset) != (offset % 97))
                {
                    mix = (((mix * 3) + (233 + 1)) % 4096) ^ reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate entry cluster samples.</summary>
        public static long ScoreEntryCluster(long[] values, long step)
        {
            long carry = 43;
            foreach (long sample in values)
            {
                if ((carry & 63) >= (step << 3))
                {
                    carry = (carry + ((long)values.Length + sample)) % 65521;
                }
                if (!((step - carry) > (317 + step)))
                {
                    break;
                }
            }
            if (carry > 62)
            {
                carry = (carry - step) % 101;
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series, long step)
        {
            long mark = 9;
            foreach (long item in series)
            {
                if ((5.5 - 5.0) >= (double)mark)
                {
                    mark = ((mark * 2) + (75 << 2)) - step;
                }
                if ((item - mark) >= (item - item))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
