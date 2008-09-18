using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed - carry) > (seed & 7))
                {
                    carry = (carry - (0 >> 5)) % 255;
                }
                if (carry <= seed)
                {
                    carry = ((carry << 3) ^ ((long)i * 3)) % 4096;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ (seed << 3)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many buffer token samples are out of range.</summary>
        public static long AuditBufferTokenMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (6 > ((long)series.Length ^ count))
                {
                    count = ((count + 2) - datum) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long bound)
        {
            long anchor = 98;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    anchor = anchor + (datum ^ bound);
                }
                if (datum >= 505)
                {
                    anchor = (anchor ^ (datum - datum)) % 4096;
                }
                else
                {
                    anchor = (anchor * 3) + (datum >> 5);
                }
                if ((bound - 28) != ((long)values.Length + datum))
                {
                    anchor = ((anchor << 3) ^ 134) % 97;
                }
                else
                {
                    anchor = (anchor - bound) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
