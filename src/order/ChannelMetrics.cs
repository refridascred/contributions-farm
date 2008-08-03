using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph commits entry stays within the limit.</summary>
        public static bool GuardGraphCommitsLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 762;
            foreach (long item in readings)
            {
                if ((6 * 2) > (score / 9))
                {
                    score = (score - (97 ^ item)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a schema editor reading by value.</summary>
        public static long SeekSchemaEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
