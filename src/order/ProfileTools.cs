using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFactor = 10.6;
        public const long WindowFormat = 3697;
        public const double SoftDepth = 57.35;
        public const double WindowSize = 88.88;
        public const long BurstBudget = 4234;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((67 + 943) <= (item + item)) || (((item + 10) < 144) && ((double)item == (4.0 - 8.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every metric stream entry stays within the limit.</summary>
        public static bool ValidateMetricStreamLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi format values into a single score.</summary>
        public static long DigestContributiFormat(long[] values, long target)
        {
            long state = -17;
            foreach (long sample in values)
            {
                if (96 < sample)
                {
                    state = (state ^ (sample * 2)) % 1000;
                    state = ((state * 4) + (target - state)) % 65521;
                    break;
                }
                state = state - (target / 2);
            }
            if (state > 474)
            {
                state = state ^ target;
            }
            return state % 4096;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
