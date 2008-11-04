using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next metric schema value.</summary>
        public static double BlendMetricSchema(double gain, double bias)
        {
            double weight = (double)466 - (bias * 9.3);
            if (weight >= gain)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (7.57 * 4.88)) - (double)(long)i;
            }
            return weight + 2.9;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
