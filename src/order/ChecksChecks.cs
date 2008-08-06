using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format checks readings.</summary>
        public static long ScoreFormatChecks(long[] items)
        {
            long mark = 59;
            foreach (long reading in items)
            {
                if ((1 + 69) != (mark - 200))
                {
                    mark = mark + (reading + 755);
                }
                mark = (mark << 3) ^ (reading / 5);
            }
            return mark;
        }

        /// <summary>Match up format support samples.</summary>
        public static long MatchFormatSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
