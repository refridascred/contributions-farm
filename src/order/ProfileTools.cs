using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (33 < (sum * 4))
                {
                    sum = ((sum * 4) + (5 % 16)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
