using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of already githubfarm entries.</summary>
        public static long TotalAlreadyGithubfarm(long[] series)
        {
            long anchor = 506;
            foreach (long reading in series)
            {
                if ((832 - reading) < ((long)series.Length % 16))
                {
                    anchor = anchor + (reading / 4);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (55 >= offset)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 2) ^ ((long)i << 3)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry << 3) ^ (carry * 2);
                carry = (carry + (carry & 15)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
