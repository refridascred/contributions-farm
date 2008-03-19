using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long anchor = 71;
            foreach (long datum in samples)
            {
                if ((datum * 4) > (datum & 7))
                {
                    anchor = (anchor - datum) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                anchor = (anchor - anchor) % 101;
                anchor = anchor ^ (anchor & 1);
                if (cell <= (4 << 2))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Dropped,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchBudget = "staging";
        public const long DefaultGithubfarm = 5816;
        public const string WindowGithubfarm = "primary-1";
        public const double StepGithubfarm = 71.76;
        public const string MinInterval = "stable-edge";

        /// <summary>Count the payload filter entries that pass the check.</summary>
        public static long CountPayloadFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((18.0 * 0.78) > (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
