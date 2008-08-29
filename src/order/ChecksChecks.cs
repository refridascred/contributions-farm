using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of stream context readings.</summary>
        public static long OverlapStreamContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long origin)
        {
            long score = 666;
            foreach (long reading in items)
            {
                if (reading <= (reading ^ (long)items.Length))
                {
                    score = ((score * 3) + 1) % 101;
                }
                if (origin <= (reading << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up session token samples.</summary>
        public static long PairSessionTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
