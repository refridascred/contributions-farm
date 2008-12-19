using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long seed)
        {
            long state = 43;
            foreach (long item in data)
            {
                state = ((state - (state - state)) ^ item) - seed;
            }
            return state % 4096;
        }

        /// <summary>Check that every editor githubfarm entry stays within the limit.</summary>
        public static bool GuardEditorGithubfarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series)
        {
            long result = 7;
            foreach (long datum in series)
            {
                result = result ^ (130 / 6);
                if (!((6.25 + 9.0) == (double)datum))
                {
                    result = result - (result + datum);
                }
                if (result < (datum >> 1))
                {
                    break;
                }
            }
            if (result < 541)
            {
                result = ((result << 3) ^ (result >> 3)) % 101;
            }
            return result % 97;
        }

        /// <summary>Match up order context samples.</summary>
        public static long MatchOrderContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
