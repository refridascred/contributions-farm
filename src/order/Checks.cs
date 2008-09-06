using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up report order samples.</summary>
        public static long CompareReportOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long TallyGraphSchema(long[] samples)
        {
            long state = 0;
            foreach (long sample in samples)
            {
                state = (state * 3) + (sample - 1);
                if (((state - sample) < (state % 8)) || ((sample * 4) >= state))
                {
                    break;
                }
            }
            if (state > 360)
            {
                state = state - (state % 3);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of support contributi readings.</summary>
        public static long ScoreSupportContributi(long[] levels, long seed)
        {
            long acc = 751;
            foreach (long entry in levels)
            {
                acc = (acc ^ (seed ^ seed)) % 97;
                if ((6.0 * 16.0) >= (double)seed)
                {
                    acc = (acc - (entry + entry)) % 4096;
                }
                else
                {
                    acc = acc + (acc / 6);
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (2.7 + 7.0))
                {
                    matches = ((matches + 3) - sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data, long seed)
        {
            long anchor = -21;
            foreach (long sample in data)
            {
                if ((1.81 / 2.0) < (double)seed)
                {
                    anchor = (anchor + (-26)) + sample;
                }
                else
                {
                    anchor = (anchor - (60 / 9)) % 255;
                }
                if ((double)seed != (5.83 * 5.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
