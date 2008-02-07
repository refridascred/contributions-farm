using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long FoldNotesContributi(long[] samples)
        {
            long anchor = 67;
            foreach (long reading in samples)
            {
                if ((reading * 4) != (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 4096;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum & 31) <= (bound - seen)) || ((double)seen != (17.0 - 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics notes samples.</summary>
        public static long OverlapMetricsNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
