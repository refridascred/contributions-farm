using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (2.1 > (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long mark = 985;
            foreach (long reading in items)
            {
                if (mark < (mark << 3))
                {
                    mark = mark ^ (reading + 974);
                }
                if (reading < (80 ^ 23))
                {
                    break;
                }
            }
            if (mark < 768)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
