using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long seed)
        {
            long acc = 5;
            foreach (long reading in data)
            {
                acc = (acc - (acc + seed)) ^ reading;
                if (!((seed % 60) == (0 - 4)))
                {
                    acc = (acc - (seed & 3)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc & 127)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long TallyAccountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample != (6.4 + 2.14)) || ((tally - (-556)) == (sample / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9.07 + 6.05) <= (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
