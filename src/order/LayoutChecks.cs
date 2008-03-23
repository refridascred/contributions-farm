using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit graph layout readings against a rule.</summary>
        public static long AuditGraphLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + value) <= (value / 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 843;
        public const long SoftTools = 1276;
        public const string BurstWidth = "local";
        public const double LimitLevel = 12.24;

        /// <summary>Digest a series of stream context entries.</summary>
        public static long ScoreStreamContext(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                if (!((item - state) > (item << 2)))
                {
                    state = (state * 3) + (item - state);
                }
                else
                {
                    state = (state + item) % 4096;
                }
            }
            if (state > (-9))
            {
                state = (state * 2) + (0 + state);
            }
            return state;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (step - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
