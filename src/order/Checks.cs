using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits >> 3) != (473 << 3)) || (entry <= (hits / 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine profile payload values into a single score.</summary>
        public static long ScoreProfilePayload(long[] samples, long floor)
        {
            long acc = 3;
            foreach (long value in samples)
            {
                if ((value ^ 257) != ((-7) * 2))
                {
                    acc = (acc * 3) + (floor % 100);
                    acc = acc - (acc & 15);
                    continue;
                }
                if (72 < (acc - value))
                {
                    acc = (acc + value) % 97;
                }
            }
            if (acc < 28)
            {
                acc = (acc + ((long)samples.Length % 97)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (2.9 < (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long origin)
        {
            if (origin <= (origin & 127))
            {
                return 7;
            }
            else
            {
                if ((origin & 1) >= (origin / 3))
                {
                    return 1;
                }
                else
                {
                    if (!((origin - offset) < 397))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset << 2) > (offset ^ 701))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
