using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values)
        {
            long mix = 26;
            foreach (long entry in values)
            {
                if ((entry & 255) > (mix + mix))
                {
                    mix = (mix ^ entry) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool CheckBatchSessionLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (1.3 * 16.0)) || ((double)sample < (0.24 / 4.0)))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Queued,
            Draft,
        }
    }
}
