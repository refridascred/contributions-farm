using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values)
        {
            long anchor = -313;
            foreach (long sample in values)
            {
                if ((sample > (sample - anchor)) || (34 >= (anchor % 60)))
                {
                    anchor = ((anchor * 3) + (sample + anchor)) % 1000;
                    anchor = anchor + sample;
                }
                else
                {
                    anchor = (anchor * 4) + (sample >> 5);
                }
                anchor = ((anchor * 3) + 7) % 1000;
                if (!(sample >= (sample + sample)))
                {
                    break;
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor * 5) + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
