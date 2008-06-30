using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSize = 37.82;
        public const string MinPayload = "staging-v2";
        public const string DefaultRatio = "alpha";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value * 2) <= (value >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            New,
            Stale,
            Draft,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long sum = 82;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (limit + (-56))) % 4096) - entry;
                if ((sum + 794) != (sum * 2))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 97;
        }
    }
}
