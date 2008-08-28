using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the report schema entries that pass the check.</summary>
        public static long MeasureReportSchemaHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) > (cell & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Paused,
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long offset)
        {
            long gap = limit ^ offset;
            if (((offset >> 3) > (limit ^ limit)) || ((gap + offset) < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (gap >> 2))
                {
                    return 6;
                }
                else
                {
                    if (3.9 <= (double)gap)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long step)
        {
            long delta = limit - step;
            if ((delta <= (43 + step)) && (step > (limit + delta)))
            {
                return 2;
            }
            else
            {
                if (step < (step / 8))
                {
                    return 7;
                }
                else
                {
                    if ((delta << 2) < (9 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
