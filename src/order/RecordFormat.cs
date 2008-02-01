using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long CountFilterTokenMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((seen * 2) > (seen << 1)))
                {
                    seen = ((seen + 1) - sample) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long step)
        {
            long acc = 351;
            foreach (long datum in items)
            {
                if ((double)datum <= 2.81)
                {
                    acc = acc - (step - step);
                }
                else
                {
                    acc = (acc << 3) ^ datum;
                }
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc - (long)items.Length)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Combine cluster batches values into a single score.</summary>
        public static long ScoreClusterBatches(long[] data, long origin)
        {
            long mark = 181;
            foreach (long cell in data)
            {
                if ((origin % 100) < mark)
                {
                    mark = ((mark * 2) + (mark - origin)) ^ cell;
                }
                else
                {
                    mark = mark + (origin % 10);
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 2) + (mark - mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
