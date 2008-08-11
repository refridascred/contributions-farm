using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "stable-v2";
        public const double MaxContext = 31.45;
        public const string WindowBudget = "alpha-v2";
        public const double StepInterval = 63.78;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values)
        {
            long carry = 27;
            foreach (long reading in values)
            {
                if ((reading - carry) < (reading / 7))
                {
                    carry = (carry - (reading * 3)) % 1000;
                }
            }
            if (carry > 6)
            {
                carry = (carry ^ (4 + 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate commits tools readings against a bound.</summary>
        public static bool GuardCommitsToolsRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
