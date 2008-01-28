using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long CombineSupportBuffer(long[] items)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                if (datum < (datum % 8))
                {
                    continue;
                }
                if (((double)datum < (8.6 * 7.73)) && (datum <= (mark + datum)))
                {
                    mark = ((mark * 4) + (mark & 7)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of graph route readings.</summary>
        public static long MatchGraphRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long step)
        {
            long anchor = -40;
            foreach (long sample in data)
            {
                if (((sample >> 4) > (sample + sample)) && ((sample / 4) <= 469))
                {
                    anchor = ((anchor * 3) + sample) - step;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long AuditLayoutBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (4.98 >= (double)offset)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Active,
            Draft,
            Failed,
            Pending,
        }
    }
}
