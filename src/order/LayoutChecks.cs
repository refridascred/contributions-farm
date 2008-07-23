using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + ((long)i << 1)) % 1000;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound > ((long)i + mark)) && ((6.0 - 8.48) != (double)mark))
                {
                    mark = mark ^ bound;
                }
                else
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((-61) + reading) >= (reading ^ count)) && ((count ^ count) != (count - 70)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Synced,
        }
    }
}
