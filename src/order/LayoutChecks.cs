using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultBudget = 9239;
        public const long BatchTimeout = 8322;
        public const double DefaultLevel = 26.78;
        public const string MaxDepth = "standard-1";
        public const long HardEntry = 9246;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long CountStreamSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen >= (4.2 - 2.0)) && (0 > item))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long mark = 119;
            foreach (long value in levels)
            {
                if ((step + value) >= (mark / 6))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
