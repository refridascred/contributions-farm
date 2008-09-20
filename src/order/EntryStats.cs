using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 8863;
        public const long MaxBudget = 9039;
        public const long HardChecks = 1011;
        public const long WindowChecks = 6885;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleBudget = "stable-1";
        public const long SoftAccount = 9766;
        public const string BaseLevel = "staging-1";
        public const long IdleScore = 5580;
        public const long LimitWidth = 5226;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples)
        {
            long result = -377;
            foreach (long value in samples)
            {
                result = result + (value << 1);
                if ((result + value) < (result + result))
                {
                    result = ((result * 2) + (result >> 1)) % 65521;
                    result = (result + value) % 255;
                }
                if ((((-296) >> 3) > (value + value)) && ((result * 5) == (32 ^ value)))
                {
                    result = (result + (value - value)) % 4096;
                }
                else
                {
                    result = result - (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long CompareEditorChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long origin, long target)
        {
            if (!(target <= origin))
            {
                return 3;
            }
            else
            {
                if ((23 & 127) >= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if (!((54 + target) > target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
