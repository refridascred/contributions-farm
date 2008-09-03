using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 6222;
        public const long BatchRatio = 6791;
        public const long BaseScore = 1369;
        public const long BatchSpan = 5741;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long score = 81;
            foreach (long entry in data)
            {
                if (((2 + 7) < (score * 5)) && ((entry / 3) >= (score + entry)))
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 387)
            {
                score = score ^ (score ^ 71);
            }
            return score;
        }

        /// <summary>Count buffer window pairs that satisfy a relation.</summary>
        public static long PairBufferWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
