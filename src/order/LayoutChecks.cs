using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a report batches value against two limits.</summary>
        public static long ClassifyReportBatches(long floor, long step)
        {
            if ((step + floor) <= (floor - floor))
            {
                return 6;
            }
            else
            {
                if ((4.1 * 3.4) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length <= cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long step)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                carry = ((carry + (step - step)) % 97) ^ sample;
                if (!((step ^ step) == (step % 5)))
                {
                    carry = ((carry * 2) + (step / 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ 37) % 255;
            }
            return carry % 4096;
        }
    }
}
