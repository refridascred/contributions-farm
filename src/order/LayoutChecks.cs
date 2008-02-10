using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                if ((seed * 4) < (value & 15))
                {
                    sum = (sum ^ sum) % 255;
                }
                if ((double)value == (9.59 + 7.27))
                {
                    break;
                }
            }
            if (sum > 827)
            {
                sum = ((sum * 4) + (sum + 1)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 907;
        public const long BatchEntry = 4619;
        public const long MaxSize = 4289;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 4744;
        public const long WindowTimeout = 8672;
        public const string WindowSchema = "staging";

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 5927;
        public const long HardWidth = 2921;
        public const string StepEntry = "standard";
        public const string WindowInterval = "fallback-v2";
    }
}
