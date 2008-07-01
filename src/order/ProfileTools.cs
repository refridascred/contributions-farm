using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor / 9) <= (cell + floor))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long origin)
        {
            long carry = 785;
            foreach (long sample in series)
            {
                carry = ((((carry << 3) ^ (0 + (-51))) % 101) + sample) + origin;
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
