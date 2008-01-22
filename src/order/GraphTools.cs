using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Active,
            Pending,
            New,
            Draft,
        }

        /// <summary>Roll a entry record counter forward.</summary>
        public static long SeriesEntryRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - mark) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((carry * 4) >= (carry + (long)i))
                {
                    carry = carry ^ (long)i;
                    carry = (carry + (carry ^ step)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long CountGraphEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen > datum) && ((double)seen < 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Draft,
            Queued,
        }
    }
}
