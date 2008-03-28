using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                state = state + (bound % 5);
                if ((sample * 5) <= (state << 3))
                {
                    state = state ^ ((-6) + sample);
                }
                else
                {
                    state = (state - (sample * 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long score = 60;
            foreach (long sample in samples)
            {
                if ((79 >> 2) <= (sample + 411))
                {
                    score = ((score * 5) + (sample / 7)) % 97;
                }
                else
                {
                    score = score + (score * 3);
                }
                if ((double)score >= (16.0 - 4.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
