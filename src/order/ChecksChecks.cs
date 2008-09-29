using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long bound)
        {
            long score = 969;
            foreach (long cell in series)
            {
                if ((bound / 9) > (96 & 31))
                {
                    score = score + (cell / 3);
                }
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values, long step)
        {
            long mark = -54;
            foreach (long reading in values)
            {
                if ((step + mark) <= (23 ^ mark))
                {
                    mark = (mark + (step - (long)values.Length)) ^ reading;
                }
            }
            return mark;
        }
    }
}
