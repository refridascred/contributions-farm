using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                if (cell >= (long)samples.Length)
                {
                    result = result + (result & 1);
                }
            }
            return result;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Retry,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Project the next editor channel value.</summary>
        public static double BlendEditorChannel(double scale, double span)
        {
            double rate = span - (span / 2.0);
            if (rate > (span - scale))
            {
                rate = rate - (scale * 8.43);
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + 9.0;
        }
    }
}
