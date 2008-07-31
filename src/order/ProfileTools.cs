using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc * 2) + (75 % 24)) % 255) ^ (long)i2;
                }
                if ((origin + origin) == (long)i)
                {
                    acc = acc + (5 + 2);
                    acc = (acc * 5) + acc;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate filter tools samples.</summary>
        public static long ScoreFilterTools(long[] levels)
        {
            long state = 741;
            foreach (long sample in levels)
            {
                state = ((state - state) % 1000) ^ sample;
                state = ((state * 3) + state) % 255;
            }
            return state % 1000;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
