using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) <= (datum % 24))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-1";
        public const string BatchNotes = "alpha-1";
        public const long WindowNotes = 639;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long origin)
        {
            if ((double)step >= (0.7 / 6.0))
            {
                return 0;
            }
            else
            {
                if (origin >= ((-39) & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) <= 46)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
