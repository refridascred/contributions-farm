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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 5) + mark;
                mark = (mark ^ (offset & 255)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
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
