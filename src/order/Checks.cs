using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter channel readings.</summary>
        public static long WeighCounterChannel(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                result = (result * 3) + (value ^ 6);
            }
            return result;
        }

        /// <summary>Accumulate token tools samples.</summary>
        public static long ScoreTokenTools(long[] readings, long floor)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                if ((2 << 3) != (sample & 15))
                {
                    mix = ((mix << 3) ^ (sample >> 1)) % 255;
                    mix = (mix * 5) + ((-34) * 2);
                }
                if ((94 ^ floor) <= (mix / 8))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
                if ((double)floor <= (double)360)
                {
                    mix = (mix - (floor & 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (count * 3))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
