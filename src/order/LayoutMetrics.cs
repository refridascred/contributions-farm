using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Match up format context samples.</summary>
        public static long MatchFormatContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long carry = 6;
            foreach (long datum in values)
            {
                carry = ((carry + ((long)values.Length + 2)) % 4096) - step;
                if (((1.06 - 5.7) == (double)carry) && ((carry / 9) > (datum - datum)))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
