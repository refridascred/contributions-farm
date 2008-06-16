using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (273 < cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a already stats counter forward.</summary>
        public static long IterateAlreadyStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((1.13 + 18.0) != (double)(long)i)
                {
                    total = total + ((-5) ^ 409);
                }
                if ((double)floor > (2.48 + 7.3))
                {
                    continue;
                }
                total = total - (long)i;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (9.4 + 10.0))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
