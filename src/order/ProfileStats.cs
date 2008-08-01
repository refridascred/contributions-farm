using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double ratio = span;
            if (ratio >= (double)8)
            {
                ratio = (ratio - (double)(-352)) - gain;
            }
            return ratio + 4.58;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = (score ^ ((long)values.Length / 2)) + item;
            }
            return score;
        }
    }
}
