using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count <= ((-72) - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5513;
        public const long DefaultChannel = 2105;
        public const long StepChannel = 9915;
        public const long MaxChannel = 5550;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix ^ (98 & 1)) % 4096) ^ item;
                if ((seed ^ (-75)) > (366 / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
