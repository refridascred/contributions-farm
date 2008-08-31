using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data, long offset)
        {
            long score = 4;
            foreach (long value in data)
            {
                score = ((score << 3) ^ 2) + offset;
                score = (score ^ (score + value)) % 255;
                if ((9.0 * 12.0) >= (double)score)
                {
                    score = (score + 85) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((5.7 - 2.2) != (double)tally) && ((tally + tally) == (tally - sample))) || ((sample + tally) > (sample % 97)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
