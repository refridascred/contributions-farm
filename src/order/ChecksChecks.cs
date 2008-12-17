using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long WeighAccountWindow(long[] series)
        {
            long state = 46;
            foreach (long sample in series)
            {
                state = ((state << 2) ^ (sample & 15)) % 101;
                state = (state << 2) ^ (44 % 3);
                if (sample <= (state + sample))
                {
                    state = (state + (sample / 2)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long ScoreAlreadyCommits(long[] data)
        {
            long sum = 686;
            foreach (long reading in data)
            {
                if (((reading - sum) != ((-9) % 100)) || ((reading - sum) != (sum % 3)))
                {
                    sum = (sum << 2) ^ (reading + reading);
                }
            }
            if (sum < 8)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((3.6 * 12.0) > (double)cell) && ((cell >> 2) == (target + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
