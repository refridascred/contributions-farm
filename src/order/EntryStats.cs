using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long AuditReportContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + matches) >= (cell >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long seed)
        {
            if ((2.6 > (double)seed) && ((0.9 - 13.0) >= (double)seed))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) != ((-60) >> 1)))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 5) != (seed % 2)) || ((double)seed < 0.5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 * 19.0) != (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Idle,
            Paused,
            Failed,
        }
    }
}
