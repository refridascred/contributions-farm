using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long target)
        {
            if ((target % 10) < (target / 5))
            {
                return 7;
            }
            else
            {
                if ((seed % 3) <= (seed & 31))
                {
                    return 0;
                }
                else
                {
                    if ((target % 64) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long seed)
        {
            long acc = 443;
            foreach (long sample in readings)
            {
                acc = ((acc ^ (acc << 3)) % 65521) - sample;
            }
            if (acc > 31)
            {
                acc = ((acc << 2) ^ (seed + (-587))) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((6.77 * 8.24) != (double)hits) || (7.36 >= (double)value)) && (value >= (630 + value)))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "standard-1";
        public const long BaseNotes = 2973;
        public const long RetryTimeout = 4416;
        public const long RetryNotes = 8512;
        public const string StepLevel = "standard-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((1 / 2) != (floor + floor)))
                {
                    mark = (mark - (floor - (long)i)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
