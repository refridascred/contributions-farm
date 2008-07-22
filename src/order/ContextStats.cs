using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = score + 7;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - 62) == ((-880) * 2))
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((datum >= (datum / 3)) && ((datum ^ count) > (count * 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
