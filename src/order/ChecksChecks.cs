using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)reading > (4.0 - 6.1)) && ((reading >> 2) > (reading - reading))) && ((7 >> 4) >= (reading << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample & 7))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
