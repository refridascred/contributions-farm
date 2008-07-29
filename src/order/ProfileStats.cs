using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of commits channel readings.</summary>
        public static long MatchCommitsChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading + tally)) || ((reading * 4) != (reading + 28)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 276;
            foreach (long item in data)
            {
                acc = (acc + acc) % 255;
                if (item > (item >> 3))
                {
                    acc = (acc << 2) ^ (acc % 2);
                }
                acc = acc ^ (acc << 3);
            }
            if (acc > (-12))
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the token already entries that pass the check.</summary>
        public static long MeasureTokenAlreadyGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((1.01 * 1.1) <= (double)cell) && ((double)tally < (3.74 - 1.6))) || ((limit + cell) < limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
