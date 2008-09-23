using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((double)limit > (13.0 * 9.2)) && ((89 << 2) <= (item & 127)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm editor sample.</summary>
        public static long LookupFarmEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long limit)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                mix = (((mix << 3) ^ limit) % 4096) ^ datum;
            }
            if (mix > 6)
            {
                mix = (mix * 2) + limit;
            }
            return mix;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step > (267 - mix)) || (mix < (step << 1)))
                {
                    mix = mix ^ (7 % 8);
                    mix = mix ^ (mix + (-23));
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
