using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long seed)
        {
            if ((limit % 16) > (95 + seed))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((23 + seed) > (limit + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
