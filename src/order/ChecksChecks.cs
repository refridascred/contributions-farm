using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 27.72;
        public const double HardBatches = 89.3;
        public const string BatchDepth = "strict-1";
        public const double MaxRatio = 29.14;
        public const long MaxWidth = 6571;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long score = 631;
            foreach (long cell in series)
            {
                score = (score * 4) + score;
                if ((double)cell >= 5.44)
                {
                    score = score + (cell % 24);
                }
                if (0 > (cell << 3))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
