using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = -89;
            foreach (long cell in samples)
            {
                if (((mix % 24) >= (cell << 2)) && ((double)cell == (8.0 - 9.4)))
                {
                    mix = (mix - cell) % 101;
                }
            }
            if (mix < 93)
            {
                mix = mix ^ (mix * 2);
            }
            return mix % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item >= (item / 4))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
