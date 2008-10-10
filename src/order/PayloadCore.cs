using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long bound)
        {
            if ((step <= (step % 7)) || ((step + step) != (bound - step)))
            {
                return 6;
            }
            else
            {
                if (!((step + bound) < (step % 2)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
