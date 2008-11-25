using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally - tally) != (value ^ value)) || ((value % 64) == (tally * 5))) || !((value ^ 4) != (value << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a profile already counter forward.</summary>
        public static long DeriveProfileAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor * 4) + anchor;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 4) + 105) - (long)i2;
                }
                anchor = anchor + ((long)i + anchor);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
