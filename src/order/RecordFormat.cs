using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 63) > (reading - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool VerifyEditorLayoutRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long floor)
        {
            long prev = seed ^ floor;
            if (((floor + seed) > ((-79) << 2)) || ((prev & 31) < floor))
            {
                return 5;
            }
            else
            {
                if ((4 + prev) > 5)
                {
                    return 8;
                }
                else
                {
                    if ((seed - prev) <= (seed & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed ^ prev) >= (seed ^ seed)) || (floor >= (seed + prev)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order record samples are out of range.</summary>
        public static long CountOrderRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (1.71 / 3.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data, long origin)
        {
            long mix = 8;
            foreach (long cell in data)
            {
                mix = ((mix - (4 + origin)) % 1000) ^ cell;
            }
            return mix;
        }
    }
}
