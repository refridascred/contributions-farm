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

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((14.0 < (double)reading) || (step > matches)) || ((((long)data.Length * 2) < 441) && ((1.3 - 2.12) != (double)step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
