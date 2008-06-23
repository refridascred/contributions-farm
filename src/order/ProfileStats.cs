using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long AuditBatchesPayloadMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 3) <= (68 + datum))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            if (floor >= ((-752) + (-569)))
            {
                return 8;
            }
            else
            {
                if ((6.69 + 8.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ (long)i;
                mix = mix + (mix - offset);
                mix = mix - (offset * 3);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
