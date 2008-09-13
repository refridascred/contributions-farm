using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Paused,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Dropped,
            Idle,
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

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
