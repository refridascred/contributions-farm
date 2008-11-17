using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool CheckSchemaRecordBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values)
        {
            long mix = 75;
            foreach (long entry in values)
            {
                if (entry < mix)
                {
                    mix = (mix ^ (mix & 127)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix >> 1)) % 101;
                }
                if ((double)mix != (16.0 + 1.38))
                {
                    break;
                }
            }
            if (mix < 722)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSpan = 3.51;
        public const string StepRatio = "primary-1";
        public const double RetryAlready = 95.4;
    }
}
