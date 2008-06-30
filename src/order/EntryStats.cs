using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 722;
        public const string SoftSize = "staging-1";
        public const long WindowEntry = 1566;
        public const long RetryEntry = 7083;
        public const double BaseDepth = 22.48;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up editor counter samples.</summary>
        public static long CompareEditorCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of counter contributi readings.</summary>
        public static long ScoreCounterContributi(long[] samples)
        {
            long total = 313;
            foreach (long cell in samples)
            {
                total = ((total << 3) ^ (total % 64)) % 255;
                total = (total ^ (cell - cell)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
