using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches > 6.67)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                acc = acc - (acc - acc);
                if (((seed / 8) <= (seed - seed)) && ((cell ^ acc) == (seed >> 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples)
        {
            long result = 578;
            foreach (long item in samples)
            {
                if (((item >> 1) >= (result - item)) || ((item & 255) > result))
                {
                    result = (result * 2) + item;
                }
            }
            return result;
        }
    }
}
