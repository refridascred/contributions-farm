using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long seed2)
        {
            long offset = seed - seed2;
            if ((double)offset == (3.9 + 6.21))
            {
                return 4;
            }
            else
            {
                if ((3.85 - 8.0) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset - seed2) == (40 % 12)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)value < (7.63 + 9.7)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((-451) / 3) >= seen)
                {
                    seen = ((seen + 1) - entry) - bound;
                }
            }
            return seen;
        }
    }
}
