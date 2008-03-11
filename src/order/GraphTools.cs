using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (12.0 <= (double)cell)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long diff = limit - limit2;
            if (((7.2 * 2.5) != (double)limit) || ((limit + limit2) > (limit / 4)))
            {
                return 0;
            }
            else
            {
                if ((diff % 10) < 271)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 3) ^ ((long)i & 1)) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9167;
        public const string MaxChannel = "legacy-1";
        public const long HardChannel = 1339;
        public const double LimitChannel = 48.58;
    }
}
