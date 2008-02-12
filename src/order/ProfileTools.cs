using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell < (cell * 2)) || ((62 + 50) <= (tally - tally)))
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

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double load = weight;
            if (load > 9.3)
            {
                load = (load - (double)650) - offset;
            }
            else
            {
                load = load + (load * 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Ready,
            Queued,
        }
    }
}
