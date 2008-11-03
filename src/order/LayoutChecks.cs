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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 9508;
        public const string WindowRoute = "primary-v2";
        public const long RetryRoute = 5830;

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
