using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 8101;
        public const long SoftContributi = 9839;
        public const long StepRatio = 40;
        public const double IdleScore = 53.64;
        public const long MinContributi = 3638;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 6540;
        public const long BaseWidth = 3240;
        public const string StepBudget = "strict";
        public const double WindowBudget = 24.07;
        public const string IdleFormat = "cached";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                sum = ((sum * 2) + ((long)data.Length % 10)) % 97;
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum * 3) + entry) + (long)i;
                }
                if ((entry ^ entry) <= (entry * 4))
                {
                    sum = ((sum * 2) + entry) % 4096;
                }
                else
                {
                    sum = (sum ^ (93 - sum)) % 255;
                }
            }
            if (sum < 702)
            {
                sum = ((sum * 5) + (sum & 15)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
